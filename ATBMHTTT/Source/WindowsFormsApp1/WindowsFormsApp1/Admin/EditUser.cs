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
    public partial class EditUser : Form
    {
        string username, password;
        public EditUser(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;  
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()==""|| textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if(checkBox1.Checked==false&&checkBox2.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn Lock hoặc Unlock");
            }    
            else
            {
                if(Support.InitConnection(textBox1.Text.Trim(),textBox2.Text.Trim())=="")
                {
                    Support.Disconnect();
                    Support.InitConnection(this.username, this.password);
                    string sql= "alter session set \"_ORACLE_SCRIPT\"=true";
                    Support.RunSQL(sql);
                    if(checkBox1.Checked==true)
                    {
                        sql = "ALTER USER "+ textBox1.Text.Trim() + " IDENTIFIED BY "+textBox3.Text.Trim()+"  ACCOUNT LOCK";
                        Support.RunSQL(sql); 
                    }
                    else
                    {
                        sql = "ALTER USER " + textBox1.Text.Trim() + " IDENTIFIED BY " + textBox3.Text.Trim() + "  ACCOUNT UNLOCK";
                        Support.RunSQL(sql);
                    }    
                }
            }    
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                checkBox2.Checked = false;
            }    
        }
    }
}
