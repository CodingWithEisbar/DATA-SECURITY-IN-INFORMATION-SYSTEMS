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
using WindowsFormsApp1.TruongDeAn;

namespace WindowsFormsApp1.TaiChinh
{
    public partial class ThongTinTaiChinh : Form
    {
        string username;
        string password;
        public ThongTinTaiChinh(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loadData();
        }

        private void loadData()
        {
            string sql_query = "SELECT * FROM ADMIN.NHANVIEN WHERE USERNAME = '" + username + "'";
            Support.InitConnection(this.username, this.password);
            thongTinTaiChinhDataGridView.DataSource = Support.GetDataToTable(sql_query);
            Support.Disconnect();
        }
        private void TaiChinh_Main()
        {
            Application.Run(new TaiChinh_Main(this.username, this.password));
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Thread t;
            this.Close();
            t = new Thread(TaiChinh_Main);
            t.Start();
        }
    }
}
