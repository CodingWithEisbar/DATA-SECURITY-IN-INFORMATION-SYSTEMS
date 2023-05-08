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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Admin
{
    public partial class AllUser : Form
    {
        private string userName,password;
        [Obsolete]
        public AllUser(string userName, string password)
        {
            InitializeComponent();
            this.userName= userName;
            this.password= password;
            loadData();
        }
        //last_login is not null and
        [Obsolete]
        private void loadData()
        {
            string sql = "select*from dba_users where last_login is not null and default_tablespace='USERS'";
            Support.InitConnection(this.userName, this.password);
            dataGridView1.DataSource= Support.GetDataToTable(sql);
            Support.Disconnect();

        }
        private void Home()
        {
            Application.Run(new Main(this.userName,this.password));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(Home);
            t.Start();
        }
    }
}
