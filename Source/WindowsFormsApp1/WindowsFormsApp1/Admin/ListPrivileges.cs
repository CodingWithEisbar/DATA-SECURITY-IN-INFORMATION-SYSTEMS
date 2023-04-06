using Funnction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Admin
{
    public partial class ListPrivileges : Form
    {
        [Obsolete]
        string username, password; 
        public ListPrivileges(string usename,string password)
        {
            InitializeComponent();
            this.username=usename;
            this.password=password;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select*from dba_tab_privs where grantee='" + textBox1.Text.Trim().ToUpper() + "'";
            Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Support.GetDataToTable(sql);
            Support.Disconnect();
        }

        private void Home()
        {
            Application.Run(new Main(this.username, this.password));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(Home);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select*from dba_col_privs where grantee='" + textBox1.Text.Trim().ToUpper() +"'";
            Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Support.GetDataToTable(sql);
            Support.Disconnect();
        }
    }
}
