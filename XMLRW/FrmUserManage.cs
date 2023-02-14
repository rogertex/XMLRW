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
        
        

        UserHelper userHelper = new UserHelper("");
        List<User> users = new List<User>();
        DataTable userDataTable;
        public FrmUserManage()
        {
            InitializeComponent();
            userHelper.CheckSupperUser("users.rog", users);
            LoadUsers();

        }

        public void LoadUsers()
        {
            userDataTable = new DataTable();
            userDataTable.Columns.Add("Index", typeof(int));
            userDataTable.Columns.Add("Username", typeof(string));
            userDataTable.Columns.Add("Password", typeof(string));
            userDataTable.Columns.Add("Level", typeof(Authority));

            users = userHelper.DeSerializedUser("users.rog");
            foreach (var user in users)
            {
                userDataTable.Rows.Add(user.Index, user.Username, user.Password, user.Level);

            }
            dataGridView1.DataSource = userDataTable;

        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                User user = new User();
                user.Index = Convert.ToInt32(dataGridView1.Rows[i].Cells["Index"].Value);
                user.Username = dataGridView1.Rows[i].Cells["Username"].Value.ToString();
                user.Password = dataGridView1.Rows[i].Cells["Password"].Value.ToString();
                user.Level = (Authority)(dataGridView1.Rows[i].Cells["Level"].Value);
                users.Add(user);
            }
            userHelper.SerializeUser("users.rog", users);

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    // 选中该行
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[e.RowIndex].Selected = true;

                    // 显示右键菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    users = userHelper.DeSerializedUser("users.rog");
                    foreach (var user in users)
                    {
                        if (user.Index == dataGridView1.SelectedRows[0].Index)
                        {
                            users.Remove(user);
                            break;
                        }

                    }
                    userHelper.SerializeUser("users.rog", users);

                    dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frmAddUser = new FrmAddUser();
            frmAddUser.ItemEvent += new Action(LoadUsers); //注册事件刷新users datagridview
            frmAddUser.ShowDialog();
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnRefashDGV_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;
            

        }
    }
}
