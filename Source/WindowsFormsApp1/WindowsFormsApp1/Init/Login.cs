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
        
        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.userName= textBox1.Text.Trim();
                this.password= textBox2.Text.Trim();   
                InitLogin(this.userName, this.password);
                this.Close();
                t = new Thread(Main);
                t.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Messeage",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
