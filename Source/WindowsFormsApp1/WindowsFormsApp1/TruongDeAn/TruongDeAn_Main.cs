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
        private string username;
        private string password;
        public TruongDeAn_Main(string userName, string passWord)
        {
            this.username = userName;
            this.password = passWord;
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

        [Obsolete]
        private void ThongTinTruongDeAn()
        {
            Application.Run(new ThongTinTruongDeAn(this.username, this.password));
        }

        private void ChinhSuaDeAn()
        {
            Application.Run(new ChinhSuaDeAn(this.username, this.password));
        }
        private void XemDanhSachDeAn()
        {
            Application.Run(new XemDanhSachDeAn(this.username, this.password));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ThongTinTruongDeAn);
            t.Start();
        }

        private void btnXemDeAn_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(XemDanhSachDeAn);
            t.Start();
        }

        private void btnChinhSuaThongTinDeAn_Click(object sender, EventArgs e)
        {
            this.Close();
            t = new Thread(ChinhSuaDeAn);
            t.Start();
        }
    }
}
