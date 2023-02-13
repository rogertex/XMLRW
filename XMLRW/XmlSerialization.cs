using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLRW
{
   public class XmlSerialization
    {



        static List<User> users = new List<User>();
        public static void SerializeUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("Users.xml", FileMode.Create))
            {
                serializer.Serialize(fs, users);
            }
        }

       public static List<User> DeserializeUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream("Users.xml", FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    return (List<User>)serializer.Deserialize(fs);
                }
                else
                {
                    return new List<User>();
                }
            }
        }

    }
}



 
 
    



