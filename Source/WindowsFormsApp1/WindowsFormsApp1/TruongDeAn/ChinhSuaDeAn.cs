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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1.TruongDeAn
{
   
    public partial class ChinhSuaDeAn : Form
    {
        string username;
        string password;
        public ChinhSuaDeAn(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            loadData();
        }

        private void loadData()
        {
            string sql_query = "SELECT * FROM ADMIN.DEAN";
            Support.InitConnection(this.username, this.password);
            chinhSuaDataGridView.DataSource = Support.GetDataToTable(sql_query);
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

        private void updateButton_Click(object sender, EventArgs e)
        {
            int x = chinhSuaDataGridView.CurrentCell.RowIndex;
            string MADA = chinhSuaDataGridView.Rows[x].Cells[0].Value.ToString();
            string TENDA = chinhSuaDataGridView.Rows[x].Cells[1].Value.ToString();
            DateTime NGAYBD = Convert.ToDateTime(chinhSuaDataGridView.Rows[x].Cells[2].Value.ToString());
            string PHONG = chinhSuaDataGridView.Rows[x].Cells[3].Value.ToString();
            string MATRGDA = chinhSuaDataGridView.Rows[x].Cells[4].Value.ToString();
            
            string sql_query = "CALL ADMIN.update_DEAN (" + MADA + ", N'" + TENDA + "', TO_DATE('" + NGAYBD.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy')," + PHONG + MATRGDA + ")";
            Support.InitConnection(this.username, this.password);
            Support.RunSQL(sql_query);
            Support.Disconnect();
            loadData();
        }
    }
}

