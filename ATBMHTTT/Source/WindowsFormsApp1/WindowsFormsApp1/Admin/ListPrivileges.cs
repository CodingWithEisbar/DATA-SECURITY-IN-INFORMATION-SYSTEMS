using Funnction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin
{
    public partial class ListPrivileges : Form
    {
        [Obsolete]
        public ListPrivileges()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select*from dba_tab_privs where grantee='" + textBox1.Text.Trim().ToUpper() + "'";
            Support.InitConnection("admin", "admin");
            dataGridView1.DataSource = Support.GetDataToTable(sql);
            Support.Disconnect();
        }
    }
}
