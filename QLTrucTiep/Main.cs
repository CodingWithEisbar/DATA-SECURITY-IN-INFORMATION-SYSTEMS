using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.QLTrucTiep
{
    public partial class Main : Form
    {
        private string userName { get; set; }
        private string password { get; set; }
        public Main(string username,string password)
        {
            InitializeComponent();
            this.userName= username; 
            this.password= password;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
            if (comboBox1.Text == "NHANVIEN")
            {
                button1.Enabled = true;
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                button1.Enabled = false;
            }
            else if (comboBox1.Text == "PHONGBAN")
            {
                button1.Enabled = false;
            }
            else if (comboBox1.Text == "DEAN")
            {
                button1.Enabled = false;
            }
        }
        private void loadData()
        {
            if (comboBox1.Text == "NHANVIEN")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select MANV,USERNAME,TenNV,Phai,NgaySinh,DiaChi,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,Luong,phucap,vaitro,manql,phg from admin.NhanVien_Select_QL";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select*from admin.PhanCong_Select_QL";
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
            
            int x = dataGridView1.CurrentCell.RowIndex;
            if (this.userName == dataGridView1.Rows[x].Cells[1].Value.ToString())
            {
                DateTime date = Convert.ToDateTime(dataGridView1.Rows[x].Cells[4].Value.ToString());
                string sql = "update admin.Nhanvien_select_ql set ngaysinh=TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy'),diachi=N'" + dataGridView1.Rows[x].Cells[5].Value.ToString().Trim() + "',sodt='" + dataGridView1.Rows[x].Cells[6].Value.ToString().Trim() + "' where manv=" + dataGridView1.Rows[x].Cells[0].Value.ToString().Trim() + "";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();
            }
            else
            {
                MessageBox.Show("Không thể thực hiện");
            }
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
