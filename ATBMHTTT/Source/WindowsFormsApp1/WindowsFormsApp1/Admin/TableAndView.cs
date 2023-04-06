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
    public partial class TableAndView : Form
    {
        string username, password;
        public TableAndView(string username,string password)
        {
            InitializeComponent();
            this.username = username;  
            this.password = password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT table_name,tablespace_name FROM ALL_TABLES WHERE OWNER='ADMIN'";
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
            string sql = "SELECT view_name,text FROM ALL_VIEWS WHERE OWNER='ADMIN'";
            Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Support.GetDataToTable(sql);
            Support.Disconnect();
        }
    }
}
