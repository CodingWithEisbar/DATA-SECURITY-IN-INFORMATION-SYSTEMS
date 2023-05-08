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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1.Admin
{
    public partial class RevokePrivilege : Form
    {
        private string username, password;
        public RevokePrivilege(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            fillComboBox();
        }

        
        private void loadData()
        {
            string sql = "select column_name from all_tab_columns where table_name = '" + comboBox1.Text.Trim().ToUpper() + "'";
            Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Support.GetDataToTable(sql);
            Support.Disconnect();
        }

        private void fillComboBox()
        {
            string sql = "select distinct role from role_tab_privs";
            Support.InitConnection(this.username, this.password);
            DataTable all_role = Support.GetDataToTable(sql);
            Support.Disconnect();
            foreach (DataRow row in all_role.Rows)
            {
                comboBox3.Items.Add(row["ROLE"]).ToString();
            }
            sql = "select username from dba_users where last_login is not null and default_tablespace='USERS'";
            Support.InitConnection(this.username, this.password);
            DataTable all_user = Support.GetDataToTable(sql);
            Support.Disconnect();
            foreach (DataRow row in all_user.Rows)
            {
                comboBox4.Items.Add(row["username"]).ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "revoke "+comboBox3.Text+" from "+ comboBox4.Text;
           
                Support.InitConnection(this.username, this.password);
                Support.RunSQL(sql);
                Support.Disconnect();
        }

        private void Home()
        {
            Application.Run(new Main(this.userName, this.password));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(Home);
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text != "UPDATE")
            {
                    string sql = "REVOKE " + comboBox2.Text + " ON " + comboBox1.Text + " FROM " + textBox4.Text.Trim() + "";
                    Support.InitConnection(this.username, this.password);
                    Support.RunSQL(sql);
                    Support.Disconnect();
            }
            else
            {
                if (textBox5.Text == "")
                {
                    
                        string sql = "REVOKE " + comboBox2.Text + " ON " + comboBox1.Text + " FROM " + textBox4.Text.Trim() + "";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    
                }
                else
                {
                        string sql = "REVOKE " + comboBox2.Text + " (" + textBox5.Text + ") ON " + comboBox1.Text + " FROM " + textBox4.Text.Trim() + "";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                }
            }
        }
    }
}
