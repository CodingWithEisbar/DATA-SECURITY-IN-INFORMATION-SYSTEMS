using Funnction;
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

namespace WindowsFormsApp1.TruongDeAn
{
    public partial class XemDanhSachDeAn : Form
    {
        string username;
        string password;
        public XemDanhSachDeAn(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loadData();
        }

        private void loadData ()
        {
            string sql_query = "SELECT * FROM ADMIN.DEAN";
            Support.InitConnection(this.username, this.password);
            deAnDataGridView.DataSource = Support.GetDataToTable(sql_query);
            Support.Disconnect();

        }
        private void TruongDeAn_Main()
        {
            Application.Run(new TruongDeAn_Main(this.username, this.password));
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(TruongDeAn_Main);
            t.Start();
        }
    }
}
