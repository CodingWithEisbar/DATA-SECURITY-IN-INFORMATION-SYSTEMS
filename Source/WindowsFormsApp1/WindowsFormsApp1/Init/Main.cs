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
using WindowsFormsApp1.Init;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            txbShowUSERNAME.Text = userName.ToUpper().Trim();
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
        private void btnUSER_Click(object sender, EventArgs e)
        {
           this.Close();
           t = new Thread(AllUser);
            t.Start();
        }

        private void BackToLogin()
        { 

            Application.Run(new Login());

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Thread t;
            this.Close();
            t = new Thread(BackToLogin);
            t.Start();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(CreateUser);
            t.Start();
        }

        private void btnGrantPrivilege_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(GrantAndEditPrivilegesUserOrRule);
            t.Start();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            this.Close();
            t = new Thread(DeleteUserOrRole);
            t.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(EditUser);
            t.Start();
        }

        private void btnRevokePrivilege_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(RevokePrivilege);
            t.Start();
        }

        private void btnShowTableView_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(TableAndView);
            t.Start();
        }

        private void btnPrivilege_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ListPrivileges);
            t.Start();
        }
    }
}
