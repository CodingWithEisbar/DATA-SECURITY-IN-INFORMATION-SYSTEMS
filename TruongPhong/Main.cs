using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1.TruongPhong
{
    public partial class Main : Form
    {
        private string userName { get; set; }
        private string password { get; set; }
        private string[] manv { get; set; }
        private string[] madean { get; set; }
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
                button1.Enabled = true;
                button3.Enabled= true;
                button4.Enabled= true;
            }
            else if (comboBox1.Text == "PHONGBAN")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            else if (comboBox1.Text == "DEAN")
            {
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
        private void loadData()
        {
            if (comboBox1.Text == "NHANVIEN")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select MANV,USERNAME,TenNV,Phai,NgaySinh,DiaChi,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,Luong,phucap,vaitro,manql,phg from admin.Nhanvien_Select_TP";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select*from admin.PhanCong_Select_TP";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
                int count = dataGridView1.Rows.Count;
                this.manv = new string[count];
                this.madean= new string[count];
                for (int i = 0; i < count - 1; i = i + 1)
                {
                    this.manv[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    this.madean[i] = dataGridView1.Rows[i].Cells[1].Value.ToString();
                }
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
            if(comboBox1.Text=="NHANVIEN")
            {
                int x = dataGridView1.CurrentCell.RowIndex;
                if (this.userName == dataGridView1.Rows[x].Cells[1].Value.ToString())
                {
                    DateTime date = Convert.ToDateTime(dataGridView1.Rows[x].Cells[4].Value.ToString());
                    string sql = "update admin.Nhanvien_select_TP set ngaysinh=TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy'),diachi=N'" + dataGridView1.Rows[x].Cells[5].Value.ToString().Trim() + "',sodt='" + dataGridView1.Rows[x].Cells[6].Value.ToString().Trim() + "' where manv=" + dataGridView1.Rows[x].Cells[0].Value.ToString().Trim() + "";
                    Funnction.Support.InitConnection(this.userName, this.password);
                    try { Funnction.Support.RunSQL(sql); }
                    catch
                    {
                        MessageBox.Show("Thất bại");
                    }
                    sql = "select MANV,USERNAME,TenNV,Phai,NgaySinh,DiaChi,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,Luong,phucap,vaitro,manql,phg from admin.NhanVien_Select_TP";
                    dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                    Funnction.Support.Disconnect();
                }
                else
                {
                    MessageBox.Show("Không thể thực hiện");
                }
            }
            else
            {
                int x = dataGridView1.CurrentCell.RowIndex;
                DateTime date = Convert.ToDateTime(dataGridView1.Rows[x].Cells[2].Value.ToString());
                string sql = "update admin.PhanCong_Select_TP set manv=" + dataGridView1.Rows[x].Cells[0].Value.ToString() + ",mada="+ dataGridView1.Rows[x].Cells[1].Value.ToString() + ",thoigian=TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy') where manv="+this.manv[x]+" and mada=" + this.madean[x] +"";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
                int x = dataGridView1.CurrentCell.RowIndex;

                string sql = "delete admin.PhanCong_Select_TP where manv=" + this.manv[x]+" and mada=" + this.madean[x] +"";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count;
            if (dataGridView1.Rows[count - 2].Cells[2].Value.ToString()==""|| dataGridView1.Rows[count - 2].Cells[1].Value.ToString() == ""|| dataGridView1.Rows[count - 2].Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }    
            else
            {
                int x = dataGridView1.CurrentCell.RowIndex;
                DateTime date = Convert.ToDateTime(dataGridView1.Rows[count - 2].Cells[2].Value.ToString());
                string sql = "insert into admin.phancong_select_tp values (" + dataGridView1.Rows[count - 2].Cells[0].Value.ToString() + "," + dataGridView1.Rows[count - 2].Cells[1].Value.ToString() + ",TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy'))";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();

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
