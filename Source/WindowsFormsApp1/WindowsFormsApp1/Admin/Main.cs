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
    public partial class Main : Form
    {
        Thread t;
        private string userName,password;
        public Main(string userName,string password)
        {
            this.userName = userName;
            this.password = password;
            InitializeComponent();
            textBox2.Text = userName.ToUpper().Trim();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void AllUser()
        {
            Application.Run(new AllUser(this.userName,this.password));
        }
        private void ListPrivileges()
        {
            
            Application.Run(new ListPrivileges());
        }
        private void CreateUser()
        {

            Application.Run(new CreateUser());
        }
        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
           t = new Thread(AllUser);
           t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(CreateUser);
            t.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ListPrivileges);
            t.Start();
        }
    }
}
