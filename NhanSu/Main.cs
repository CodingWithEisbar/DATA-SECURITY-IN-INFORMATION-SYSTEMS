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

namespace WindowsFormsApp1.NhanSu
{
    public partial class Main : Form
    {
        private string userName { get; set; }
        private string password { get; set; }
        public Main(string userName,string password)
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
                button3.Enabled = true;
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
            else if (comboBox1.Text == "PHONGBAN")
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
            else if (comboBox1.Text == "DEAN")
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }
        }
        private void loadData()
        {
            /*NHANVIEN
            PHANCONG
            PHONGBAN
            DEAN*/
            if (comboBox1.Text == "NHANVIEN")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select MANV,USERNAME,TenNV,Phai,NgaySinh,DiaChi,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,Luong,phucap,vaitro,manql,phg from admin.Nhanvien_Select_NS";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select*from admin.PhanCong_Select_NS";
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
                string sql = "CALL admin.update_NV_NS(" + dataGridView1.Rows[x].Cells[0].Value.ToString() + ",'" + dataGridView1.Rows[x].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[x].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[x].Cells[3].Value.ToString() + "',TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy'),'" + dataGridView1.Rows[x].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[x].Cells[6].Value.ToString() + "','" + dataGridView1.Rows[x].Cells[9].Value.ToString() + "','" + dataGridView1.Rows[x].Cells[10].Value.ToString() + "','" + dataGridView1.Rows[x].Cells[11].Value.ToString() + "')";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();
            }
            else
            {
                int x = dataGridView1.CurrentCell.RowIndex;
                string sql = "update admin.phongban set trphg=" + dataGridView1.Rows[x].Cells[2].Value.ToString() + ", tenpb='"+ dataGridView1.Rows[x].Cells[1].Value.ToString() + "' where mapb=" + dataGridView1.Rows[x].Cells[0].Value.ToString() + "";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "NHANVIEN")
            {
                int count = dataGridView1.Rows.Count;
                if (dataGridView1.Rows[count - 2].Cells[1].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[2].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[3].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[4].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[5].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[6].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[9].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[10].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[11].Value.ToString() == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    int x = dataGridView1.CurrentCell.RowIndex;
                    DateTime date = Convert.ToDateTime(dataGridView1.Rows[count - 2].Cells[4].Value.ToString());
                    string sql = "CALL admin.insert_NV_NS('" + dataGridView1.Rows[count - 2].Cells[1].Value.ToString() + "','" + dataGridView1.Rows[count - 2].Cells[2].Value.ToString() + "','" + dataGridView1.Rows[count - 2].Cells[3].Value.ToString() + "',TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy'),'" + dataGridView1.Rows[count - 2].Cells[5].Value.ToString() + "','" + dataGridView1.Rows[count - 2].Cells[6].Value.ToString() + "','" + dataGridView1.Rows[count - 2].Cells[9].Value.ToString() + "','" + dataGridView1.Rows[count - 2].Cells[10].Value.ToString() + "','" + dataGridView1.Rows[count - 2].Cells[11].Value.ToString() + "')";
                    Funnction.Support.InitConnection(this.userName, this.password);
                    Funnction.Support.RunSQL(sql);
                    Funnction.Support.Disconnect();
                    loadData();

                }
            }
            else
            {
                int count = dataGridView1.Rows.Count;
                if (dataGridView1.Rows[count - 2].Cells[1].Value.ToString() == "" || dataGridView1.Rows[count - 2].Cells[2].Value.ToString() == "")
                    {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                else
                {
                    int x = dataGridView1.CurrentCell.RowIndex;
                    string sql = "insert into admin.phongban(tenpb,trphg) values ('"+dataGridView1.Rows[count - 2].Cells[1].Value.ToString()+ "', "+dataGridView1.Rows[count - 2].Cells[2].Value.ToString()+")";
                    Funnction.Support.InitConnection(this.userName, this.password);
                    Funnction.Support.RunSQL(sql);
                    Funnction.Support.Disconnect();
                    loadData();

                }
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
