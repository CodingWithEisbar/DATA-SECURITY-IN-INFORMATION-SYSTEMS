using Funnction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.TruongDeAn
{
    public partial class XemDanhSachDeAn : Form
    {
        string username;
        string password;
        public XemDanhSachDeAn()
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void loadData ()
        {
            string sql_query = "SELECT * FROM DEAN";
            Support.InitConnection(this.username, this.password);
            deAnDataGridView.DataSource = Support.GetDataToTable(sql_query);
            Support.Disconnect();

        }
    }
}
