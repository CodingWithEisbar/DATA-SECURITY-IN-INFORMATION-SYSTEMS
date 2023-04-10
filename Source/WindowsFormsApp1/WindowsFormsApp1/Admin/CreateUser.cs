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
    public partial class CreateUser : Form
    {
        private string userName, password;
        public CreateUser(string userName, string password)
        {
            InitializeComponent();
            this.userName = userName;
            this.password = password;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Home()
        {
            Application.Run(new Main(this.userName, this.password));
        }

        // Tạo nguòi dùng mới
        private void btnAddUser_Click(object sender, EventArgs e)
        {   
            Support.InitConnection(this.userName, this.password);
            if (txbUserName.Text.Trim()==""&& txbPassword.Text.Trim() == "" && cbbRole.Text.Trim()=="")
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                MessageBox.Show(this.userName, this.password);
            }
            else if (Support.GetFieldValues("select* from dba_users where username='" + txbUserName.Text.Trim().ToUpper() + "'") != "")
            {
                // Thông báo UserName đã tồn tại
                MessageBox.Show("UserName tồn tại");
                Support.Disconnect();
            }
            else
            {
                try
                {
                    string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
                    Support.RunSQL(sql);

                    sql = "create user " + txbUserName.Text.Trim() + " IDENTIFIED BY " + txbPassword.Text.Trim() + "";
                    Support.RunSQL(sql);

                    sql = "GRANT CREATE SESSION TO " + txbUserName.Text.Trim() + "";
                    Support.RunSQL(sql);
                    
                    sql = "insert into Nhanvien(Username,vaitro) values ('" + txbUserName.Text.Trim() + "','" + cbbRole.Text.Trim() + "')";
                    MessageBox.Show(sql);
                    Support.RunSQL(sql);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Support.Disconnect();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Tạo Role mới
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            Support.InitConnection(this.userName, this.password);    
            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Support.RunSQL(sql);
            sql = "CREATE ROLE " + txbRoleName.Text.Trim();
            Support.RunSQL(sql);
            Support.Disconnect();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Quay lại
            Thread t;
            this.Close();
            t = new Thread(Home);
            t.Start();
        }
    }
}
