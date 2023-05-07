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
            string sql = "select column_name from all_tab_columns where table_name = '"+cbbTable.Text.Trim().ToUpper()+"'";
            Support.InitConnection(this.username, this.password);
            dataGridView1.DataSource = Support.GetDataToTable(sql);
            Support.Disconnect();
        }


        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            string sql = "grant " + cbbRole.Text + " to " + cbbUSER.Text + "";
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
                cbbRole.Items.Add(row["ROLE"]).ToString();
            }
            sql = "select username from dba_users where last_login is not null and default_tablespace='USERS'";
            Support.InitConnection(this.username, this.password);
            DataTable all_user = Support.GetDataToTable(sql);
            Support.Disconnect();
            foreach (DataRow row in all_user.Rows)
            {
                cbbUSER.Items.Add(row["username"]).ToString();
            }
        }


        private void Home()
        {
            Application.Run(new Main(this.username, this.password));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(Home);
            t.Start();
        }

        private void btnGrantPrivilege_Click(object sender, EventArgs e)
        {
            if(cbbPrivilege.Text != "UPDATE")
            {
                if (chboxWithGrantOption.Checked==true)
                {
                    string sql = "GRANT " + cbbPrivilege.Text + " ON " + cbbTable.Text + " TO " + txbRoleOrUserName.Text.Trim() + " with grant option";
                    Support.InitConnection(this.username, this.password);
                    Support.RunSQL(sql);
                    Support.Disconnect();
                }
                else 
                {
                    string sql = "GRANT " + cbbPrivilege.Text + " ON " + cbbTable.Text + " TO " + txbRoleOrUserName.Text.Trim() + "";
                    
                    Support.InitConnection(this.username, this.password);
                    Support.RunSQL(sql);
                    Support.Disconnect();
                }
                
            }
            else 
            {
                if(txbColumn.Text=="")
                {
                    if (chboxWithGrantOption.Checked == true)
                    {
                        string sql = "GRANT " + cbbPrivilege.Text + " ON " + cbbTable.Text + " TO " + txbRoleOrUserName.Text.Trim() + " with grant option";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    }
                    else
                    {
                        string sql = "GRANT " + cbbPrivilege.Text + " ON " + cbbTable.Text + " TO " + txbRoleOrUserName.Text.Trim() + "";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    }
                }
                else 
                {
                    if (chboxWithGrantOption.Checked == true)
                    {
                        string sql = "GRANT " + cbbPrivilege.Text + " (" + txbColumn.Text + ") ON " + cbbTable.Text + " TO " + txbRoleOrUserName.Text.Trim() + " with grant option";
                        Support.InitConnection(this.username, this.password);
                        Support.RunSQL(sql);
                        Support.Disconnect();
                    }
                    else
                    {
                        
                        string sql = "GRANT " + cbbPrivilege.Text + " (" + txbColumn.Text + ") ON " + cbbTable.Text + " TO " + txbRoleOrUserName.Text.Trim() + "";
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
