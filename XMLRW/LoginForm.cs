using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLRW
{
    public delegate void LoginInfoTransmit(User user);
    public partial class LoginForm : Form
    {
        UserHelper userHelper= new UserHelper ("");
        List<User> users= new List<User>();
        public event LoginInfoTransmit login;

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
            User user = null;
            user=userHelper.CheckUserLogin("users.rog",txtBoxName.Text,txtBoxPWD.Text);
            if (user!=null)
            {
                
                login(user);
                CurrentInfo.btnLogin = "退出登录";
                this.Close();

            }
            else
            {
                MessageBox.Show("密码或者用户名错误！");
            }

        }

        /// <summary>
        /// 查找主窗体是否打开
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        //private bool IsFormOpen<T>() where T : Form
        //{
        //    foreach (Form f in Application.OpenForms)
        //    {
        //        if (f.GetType() == typeof(T))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}


       
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmCurves frmCurves)
                {
                    if (frmCurves.Visible==false)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        this.Close();
                    }
                    break;
                }
            }

        }
    }
}
