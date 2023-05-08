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
    public partial class Audit : Form
    {
        private string username { get; set; }
        private string password { get; set; }   
        public Audit(string userName,string password )
        {
            InitializeComponent();
            this.username= userName;
            this.password= password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select DBUID,LSQLTEXT,NTIMESTAMP# from sys.FGA_LOG$";
            Funnction.Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
            Funnction.Support.Disconnect();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sql = "select username,EXTENDED_TIMESTAMP,obj_name,action_name,sql_text from dba_audit_trail where OBJ_NAME = 'PHANCONG' or obj_name = 'DEAN' or obj_name = 'NHANVIEN' or obj_name = 'PHONGBAN'";
            Funnction.Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
            Funnction.Support.Disconnect();

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
    }
}
