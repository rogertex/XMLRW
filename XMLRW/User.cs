using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace XMLRW
{
    [Serializable] 
    public class User
    {
        public int Index { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Authority Level { get; set; }
    }
    public enum Authority
    {
        admin,
        eng,
        op,
    }

    public class UserHelper
    {
        private string filePath = string.Empty;
        public UserHelper(string path)
        {
            filePath = path;
        }

        /// <summary>
        /// 序列化文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="users"></param>
        /// <returns></returns>
        public bool SerializeUser(string path,List<User> users)
        {
            if (users==null)
            {
                return false;
            }
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                formatter.Serialize(fs, users);
                return true;
            }
        }
        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<User> DeSerializedUser(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (FileStream fs=new FileStream(path,FileMode.Open,FileAccess.Read))
                {
                    object  o= formatter.Deserialize(fs); 
                    return o as List<User>;
                }

            }
            catch (Exception)
            {

                return null;
            }
        }


        public void CheckSupperUser(string path,List<User> users)
        {
            if (!File.Exists(path))
            {
                User user = new User()
                {
                    Index = 0,
                    Username = "Admin",
                    Password = "Admin",
                    Level = Authority.admin

                };
                users.Add(user);
                SerializeUser(path, users);

            }
        }

        
    }
    
}
