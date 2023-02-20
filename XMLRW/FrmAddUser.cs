using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XMLRW
{


    public partial class FrmAddUser : Form
    {
        public event Action ItemEvent; //定义事件用于刷新users datagridview
        UserHelper userHelper = new UserHelper("");
        List<User> users = new List<User>();


        public FrmAddUser()
        {
            InitializeComponent();
            cbxLevel.DataSource = Enum.GetNames(typeof(Authority));



        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            users = userHelper.DeSerializedUser("users.rog");
            User user = new User();
            user.Index = users.Count;
            user.Username = txtBoxName.Text;
            user.Password = txtBoxPWD.Text;
            user.Level = (Authority)Enum.Parse(typeof(Authority), cbxLevel.SelectedItem.ToString(), false);
            users.Add(user);
            userHelper.SerializeUser("users.rog", users);
            ItemEvent?.Invoke(); //触发事件 ? 表示是否有事件注册
            this.Close();

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
