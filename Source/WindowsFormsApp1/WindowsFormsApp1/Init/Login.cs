using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Funnction;
using System.Threading;
using WindowsFormsApp1.Admin;
using WindowsFormsApp1.NhanSu;
using WindowsFormsApp1.TaiChinh;
using WindowsFormsApp1.TruongDeAn;
using WindowsFormsApp1.NhanVien;

namespace WindowsFormsApp1.Init
{
    public partial class Login : Form
    {
        Thread t;
        private string userName, password;
        string NSu = "NS";
        string Tchinh = "TC";
        string TDeAn = "TDA";
        string Nvien = "NV";
        public Login()
        {
            InitializeComponent();
            txbPassword.PasswordChar = '*';

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Main()
        {

            Application.Run(new Main(this.userName,this.password));
        }
        private void NhanSu()
        {
            Application.Run(new NhanSu_Main(this.userName, this.password));
        }
        private void TaiChinh()
        {
            Application.Run(new TaiChinh_Main(this.userName, this.password));
        }
        
        private void TruongDeAn()
        {
            Application.Run(new TruongDeAn_Main(this.userName, this.password));
        }

        private void NhanVien()
        {
            Application.Run(new NhanVien_Main(this.userName, this.password));
        }

        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                this.userName= txbUserName.Text.Trim();
                this.password= txbPassword.Text.Trim();   
                InitLogin(this.userName, this.password);
                this.Close();
                if (this.userName.Contains(NSu))
                {
                    t = new Thread(NhanSu);
                }
                if (this.userName.ToLower() == "admin")
                { 
                    t = new Thread(Main); 
                }
                if (this.userName.Contains(Tchinh))
                {
                    t = new Thread(TaiChinh);
                }
                if (this.userName.Contains(TDeAn))
                {
                    t = new Thread(TruongDeAn);
                }
                if(this.userName.Contains(Nvien))
                {
                    t = new Thread (NhanVien);
                }
                t.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        [Obsolete]
        private void InitLogin(string userName, string password)
        {
            try
            {
                Support.InitConnection(userName, password);
                Support.Disconnect();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
