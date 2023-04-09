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

namespace WindowsFormsApp1.NhanSu
{
    public partial class NhanSu_Main : Form
    {
        Thread t;
        private string userName, password;
        public NhanSu_Main(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            InitializeComponent();
            txbUserName.Text = userName.ToUpper().Trim();
        }

        private void NhanSu_Main_Load(object sender, EventArgs e)
        {

        }
        private void BackToLogin()
        {

            Application.Run(new Login());

        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(BackToLogin);
            t.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
