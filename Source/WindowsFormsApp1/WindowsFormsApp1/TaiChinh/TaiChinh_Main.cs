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

namespace WindowsFormsApp1.TaiChinh
{
    public partial class TaiChinh_Main : Form
    {
        Thread t;
        private string userName;
        private string password;
        public TaiChinh_Main(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            InitializeComponent();
            txbUserName.Text = userName.ToUpper().Trim();
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
    }
}
