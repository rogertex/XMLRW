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
    public partial class FrmUserManage : Form
    {
        UserHelper userHelper= new UserHelper ("");
        List<User> listUser = new List<User>();
        public FrmUserManage()
        {
            InitializeComponent();
            userHelper.CheckSupperUser("users.rog", listUser);
            LoadUsers(); 
            
        }

        private void LoadUsers()
        {
           DataTable userDataTable = new DataTable();
            userDataTable.Columns.Add("Index", typeof(int));
            userDataTable.Columns.Add("Username", typeof(string));
            userDataTable.Columns.Add("Password", typeof(string));
            userDataTable.Columns.Add("Level", typeof(Authority));

            listUser= userHelper.DeSerializedUser("users.rog");
            foreach (var user in listUser)
            {
                userDataTable.Rows.Add(user.Index, user.Username, user.Password, user.Level);
            }
            dataGridView1.DataSource = userDataTable;
        }
      
    }
}
