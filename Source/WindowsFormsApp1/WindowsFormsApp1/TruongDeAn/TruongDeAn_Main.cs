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

namespace WindowsFormsApp1.TruongDeAn
{
    public partial class TruongDeAn_Main : Form
    {
        Thread t;
        private string userName;
        private string passWord;
        public TruongDeAn_Main()
        {
            this.userName = userName;
            this.passWord = passWord;
            InitializeComponent();
            txbUserName.Text = userName.ToUpper().Trim();
        }

        private void backToLogin()
        {
            Application.Run(new Login());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(backToLogin);
            t.Start();
        }


    }
}
