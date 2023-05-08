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
    
    public partial class Main : Form
    {
        private string userName { get; set; }
        private string password {get; set; }
        public Main(string userName, string password)
        {
            InitializeComponent();
            this.userName = userName;
            this.password = password;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
            if (comboBox1.Text == "NHANVIEN")
            {
                button1.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (comboBox1.Text == "PHONGBAN")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (comboBox1.Text == "DEAN")
            {
                button1.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
        }
        private void loadData()
        {
            if (comboBox1.Text == "NHANVIEN")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select MANV,USERNAME,TenNV,Phai,NgaySinh,DiaChi,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,Luong,phucap,vaitro,manql,phg from admin.Nhanvien";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select*from admin.PhanCong_Select_TDA";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
            else if (comboBox1.Text == "PHONGBAN")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select*from admin.PhongBan";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
            else if (comboBox1.Text == "DEAN")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select*from admin.DEAN";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "NHANVIEN")
            {

                int x = dataGridView1.CurrentCell.RowIndex;
               
                    DateTime date = Convert.ToDateTime(dataGridView1.Rows[x].Cells[4].Value.ToString());
                    string sql = "CALL admin.update_NV_NV(TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy'),N'" + dataGridView1.Rows[x].Cells[5].Value.ToString().Trim() + "','" + dataGridView1.Rows[x].Cells[6].Value.ToString().Trim() + "')";
                    Funnction.Support.InitConnection(this.userName, this.password);
                    Funnction.Support.RunSQL(sql);
                    Funnction.Support.Disconnect();
                    loadData();
            }
            else
            {
                int x = dataGridView1.CurrentCell.RowIndex;
                DateTime date = Convert.ToDateTime(dataGridView1.Rows[x].Cells[2].Value.ToString());
                string sql = "update admin.dean set tenda='"+ dataGridView1.Rows[x].Cells[1].Value.ToString() + "',ngaybd=TO_DATE('" + date.ToString("dd' - 'MM' - 'yyyy") + "', 'dd-mm-yyyy'),phong='" + dataGridView1.Rows[x].Cells[3].Value.ToString() + "' where mada=" + dataGridView1.Rows[x].Cells[0].Value.ToString() + "";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.CurrentCell.RowIndex;
            string sql = "delete admin.dean where mada=" + dataGridView1.Rows[x].Cells[0].Value.ToString() + "";
            Funnction.Support.InitConnection(this.userName, this.password);
            Funnction.Support.RunSQL(sql);
            Funnction.Support.Disconnect();
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            DateTime date = Convert.ToDateTime(dataGridView1.Rows[count-2].Cells[2].Value.ToString());
            string sql = "insert into admin.dean(tenda,ngaybd,phong) values('"+ dataGridView1.Rows[count - 2].Cells[1].Value.ToString() + "',TO_DATE('" + date.ToString("dd' - 'MM' - 'yyyy") + "', 'dd-mm-yyyy'),"+ dataGridView1.Rows[count - 2].Cells[3].Value.ToString() + ")";
            Funnction.Support.InitConnection(this.userName, this.password);
            Funnction.Support.RunSQL(sql);
            Funnction.Support.Disconnect();
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Init.Login newLogin = new Init.Login();
            this.Hide();
            newLogin.ShowDialog();
            this.Close();
        }
    }
}
