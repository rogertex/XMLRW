using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLRW
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
          

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region 注册用户
            /*            User user = new User()
                        {
                            Username = txtBoxName.Text,
                            Password = txtBoxPWD.Text
                        };
                        XmlSerializer serializer = new XmlSerializer(typeof(User));
                        using (StreamWriter streamWriter = new StreamWriter("users.xml"))
                        {
                            serializer.Serialize(streamWriter, user);
                        }

                        MessageBox.Show("User registered successfully!");*/
            #endregion 注册用户

            Form formUserManage = new FrmUserManage();

            formUserManage.Show();
        }
    }
}
