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

namespace WindowsFormsApp1.Init
{
    public partial class Login : Form
    {
        Thread t;
        private string userName, password;
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
        private void MainNV()
        {

            Application.Run(new NhanVien.Main(this.userName, this.password));
        }
        private void MainQLTT()
        {

            Application.Run(new QLTrucTiep.Main(this.userName, this.password));
        }
        private void MainTP()
        {

            Application.Run(new TruongPhong.Main(this.userName, this.password));
        }
        private void MainNS()
        {

            Application.Run(new NhanSu.Main(this.userName, this.password));
        }
        private void MainTDA()
        {

            Application.Run(new TruongDeAn.Main(this.userName, this.password));
        }
        private void MainTC()
        {

            Application.Run(new TaiChinh.Main(this.userName, this.password));
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text.Trim().Contains("NV"))
                {
                    this.userName = textBox1.Text.Trim();
                    this.password = textBox2.Text.Trim();
                    InitLogin(this.userName, this.password);
                    this.Close();
                    t = new Thread(MainNV);
                    t.Start();
                }
                else if (textBox1.Text.Trim().Contains("QLTT"))
                {
                    this.userName = textBox1.Text.Trim();
                    this.password = textBox2.Text.Trim();
                    InitLogin(this.userName, this.password);
                    this.Close();
                    t = new Thread(MainQLTT);
                    t.Start();
                }
                else if(textBox1.Text.Trim().Contains("TP"))
                {
                    this.userName = textBox1.Text.Trim();
                    this.password = textBox2.Text.Trim();
                    InitLogin(this.userName, this.password);
                    this.Close();
                    t = new Thread(MainTP);
                    t.Start();
                }
                else if (textBox1.Text.Trim().Contains("NS"))
                {
                    this.userName = textBox1.Text.Trim();
                    this.password = textBox2.Text.Trim();
                    InitLogin(this.userName, this.password);
                    this.Close();
                    t = new Thread(MainNS);
                    t.Start();
                }
                else if (textBox1.Text.Trim().Contains("TC"))
                {
                    this.userName = textBox1.Text.Trim();
                    this.password = textBox2.Text.Trim();
                    InitLogin(this.userName, this.password);
                    this.Close();
                    t = new Thread(MainTC);
                    t.Start();
                }
                else if (textBox1.Text.Trim().Contains("TDA"))
                {
                    this.userName = textBox1.Text.Trim();
                    this.password = textBox2.Text.Trim();
                    InitLogin(this.userName, this.password);
                    this.Close();
                    t = new Thread(MainTDA);
                    t.Start();
                }
                else if(textBox1.Text.Trim()== "admin" && textBox1.Text.Trim()== "admin")
                {
                    this.userName = textBox1.Text.Trim();
                    this.password = textBox2.Text.Trim();
                    InitLogin(this.userName, this.password);
                    this.Close();
                    t = new Thread(Main);
                    t.Start();
                }
                else
                {
                    MessageBox.Show("Thất Bại", "Messeage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại","Messeage",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
