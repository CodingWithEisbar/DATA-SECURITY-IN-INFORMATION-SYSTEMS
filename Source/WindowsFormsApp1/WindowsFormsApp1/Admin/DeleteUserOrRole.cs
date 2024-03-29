﻿using Funnction;
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
    public partial class DeleteUserOrRole : Form
    {
        string userName;
        string password;
        public DeleteUserOrRole(string userName,string password)
        {
            InitializeComponent();
            this.userName = userName;
            this.password = password;  
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            Support.InitConnection(this.userName, this.password);
            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Support.RunSQL(sql);
            sql = "DROP USER " + txbUserOrRole.Text.Trim().ToUpper();
            Support.RunSQL(sql);
            Support.Disconnect();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            Support.InitConnection(this.userName, this.password);
            string sql = "alter session set \"_ORACLE_SCRIPT\"=true";
            Support.RunSQL(sql);
            sql = "DROP ROLE " + txbUserOrRole.Text.Trim().ToUpper();
            Support.RunSQL(sql);
            Support.Disconnect();
        }

        private void Home()
        {
            Application.Run(new Main(this.userName, this.password));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(Home);
            t.Start();
        }
    }
}
