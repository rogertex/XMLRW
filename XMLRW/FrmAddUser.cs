using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLRW
{

    
    public partial class FrmAddUser : Form
    {
      
        UserHelper userHelper = new UserHelper("");
        List<User> users = new List<User>();
        
        public FrmAddUser()
        {
            InitializeComponent();
            cbxLevel.DataSource = Enum.GetNames(typeof(Authority));

            FrmUserManage frmUserManage = new FrmUserManage();
            frmUserManage.ItemEvent += new ItemEventHandler(LoadUsers);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            users= userHelper.DeSerializedUser("users.rog");
            User user =new User();
            user.Index = users.Count;
            user.Username=txtBoxName.Text;
            user.Password = txtBoxPWD.Text;
            user.Level = (Authority)Enum.Parse(typeof(Authority),cbxLevel.SelectedItem.ToString(),false);
            users.Add(user);
            userHelper.SerializeUser("users.rog", users);
            
            this.Close();

        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
