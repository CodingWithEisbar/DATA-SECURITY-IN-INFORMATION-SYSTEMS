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
    public partial class GrantAndEditPrivilegesUserOrRule : Form
    {
        string password, username;
        public GrantAndEditPrivilegesUserOrRule(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            fillComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            string sql = "select column_name from all_tab_columns where table_name = '"+comboBox1.Text.Trim().ToUpper()+"'";
            Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Support.GetDataToTable(sql);
            Support.Disconnect();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "grant " + comboBox3.Text + " to " + comboBox4.Text + "";
            Support.InitConnection(this.username, this.password);
            Support.RunSQL(sql);
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
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox2.Text != "UPDATE")
            {
                if (checkBox2.Checked==true)
                {
                    string sql = "GRANT " + comboBox2.Text + " ON " + comboBox1.Text + " TO " + textBox4.Text.Trim() + " with grant option";
                    Support.InitConnection(this.username, this.password);
                    Support.RunSQL(sql);
                    Support.Disconnect();
                }
                else 
                {
                    string sql = "GRANT " + comboBox2.Text + " ON " + comboBox1.Text + " TO " + textBox4.Text.Trim() + "";
                    
                    Support.InitConnection(this.username, this.password);
                    Support.RunSQL(sql);
                    Support.Disconnect();
                }
                
            }
            else 
            {
                if(textBox5.Text=="")
                {
                    if (checkBox2.Checked == true)
                    {
                        string sql = "GRANT " + comboBox2.Text + " ON " + comboBox1.Text + " TO " + textBox4.Text.Trim() + " with grant option";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    }
                    else
                    {
                        string sql = "GRANT " + comboBox2.Text + " ON " + comboBox1.Text + " TO " + textBox4.Text.Trim() + "";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    }
                }
                else 
                {
                    if (checkBox2.Checked == true)
                    {
                        string sql = "GRANT " + comboBox2.Text + " (" + textBox5.Text + ") ON " + comboBox1.Text + " TO " + textBox4.Text.Trim() + " with grant option";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    }
                    else
                    {
                        
                        string sql = "GRANT " + comboBox2.Text + " (" + textBox5.Text + ") ON " + comboBox1.Text + " TO " + textBox4.Text.Trim() + "";
                        MessageBox.Show(sql);
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    }
                }
            }
        }
    }
}
