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

namespace WindowsFormsApp1.Init
{
    public partial class Login : Form
    {
        Thread t;
        private string userName, password;
        string NSu = "NS";
        string Tchinh = "TC";
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                this.userName= textBox1.Text.Trim();
                this.password= textBox2.Text.Trim();   
                InitLogin(this.userName, this.password);
                this.Close();
                if (this.userName.Contains(NSu))
                {
                    t = new Thread(NhanSu);
                }
                if (this.userName == "admin" || this.userName == "ADMIN")
                { 
                    t = new Thread(Main); 
                }
                if (this.userName.Contains(Tchinh))
                {
                    t = new Thread(TaiChinh);
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
