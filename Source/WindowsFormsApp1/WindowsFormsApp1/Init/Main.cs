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
            
            Application.Run(new ListPrivileges(this.userName, this.password));
        }
        private void CreateUser()
        {

            Application.Run(new CreateUser(this.userName, this.password));
        }
        private void DeleteUserOrRole()
        {

            Application.Run(new DeleteUserOrRole(this.userName, this.password));
        }
        private void EditUser()
        {

            Application.Run(new EditUser(this.userName, this.password));
        }
        private void GrantAndEditPrivilegesUserOrRule() 
        {
            Application.Run(new GrantAndEditPrivilegesUserOrRule(this.userName, this.password));

        }
        private void RevokePrivilege()
        {
            Application.Run(new RevokePrivilege(this.userName, this.password));

        }
        private void TableAndView()
        {
            Application.Run(new TableAndView(this.userName, this.password));

        }
        private void Audit()
        {
            Application.Run(new Audit(this.userName, this.password));

        }
        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
           t = new Thread(AllUser);
           t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(CreateUser);
            t.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(GrantAndEditPrivilegesUserOrRule);
            t.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
            t = new Thread(DeleteUserOrRole);
            t.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(EditUser);
            t.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(RevokePrivilege);
            t.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(TableAndView);
            t.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(Audit);
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ListPrivileges);
            t.Start();
        }
    }
}
