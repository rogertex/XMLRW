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
        public FrmUserManage()
        {
            InitializeComponent();
            LoadUsers();
            ;
        }

        private void LoadUsers()
        {
           DataTable userDataTable = new DataTable();
            userDataTable.Columns.Add("Username", typeof(string));
            userDataTable.Columns.Add("Password", typeof(string));
            dataGridView1.DataSource = userDataTable;
        }
        private void FrmUserManage_Load(object sender, EventArgs e)
        {
            XmlSerialization. = XmlSerialization.SerializeUsers();

         }
    }
}
