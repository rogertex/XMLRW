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
        UserHelper userHelper= new UserHelper ("");
        List<User> users= new List<User>();

        public LoginForm()
        {
            InitializeComponent();
            userHelper.CheckSupperUser("users.rog",users);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

  

        private void btnLogin_Click(object sender, EventArgs e)
        {
         
            users= userHelper.DeSerializedUser("users.rog");
            bool loginSuccess = false;
            foreach (var user in users)
            {
                if (user.Username== txtBoxName.Text&&user.Password== txtBoxPWD.Text)
                {
                    loginSuccess = true;//// 如果用户名和密码匹配，则更改登录状态为成功
                    break;// 结束循环
                }
            }
            if (loginSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("密码或者用户名错误！");
            }

        }
    }
}
