using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.TaiChinh
{
    public partial class Main : Form
    {
        private string userName { get; set; }
        private string password { get; set; }
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
                string sql = "select MANV,USERNAME,TenNV,Phai,NgaySinh,DiaChi,cast(admin.decrypt_SODT(sodt) as nvarchar2(255)) sodt,Luong,phucap,vaitro,manql,phg from admin.Nhanvien";
                dataGridView1.DataSource = Funnction.Support.GetDataToTable(sql);
                Funnction.Support.Disconnect();
            }
            else if (comboBox1.Text == "PHANCONG")
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                string sql = "select*from admin.phancong";
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
            string sql;
            if (this.userName == dataGridView1.Rows[x].Cells[1].Value.ToString())
            {
                DateTime date = Convert.ToDateTime(dataGridView1.Rows[x].Cells[4].Value.ToString());
                sql = "CALL admin.update_NV_NV(TO_DATE('" + date.ToString("dd'-'MM'-'yyyy") + "','dd-mm-yyyy'),N'" + dataGridView1.Rows[x].Cells[5].Value.ToString().Trim() + "','" + dataGridView1.Rows[x].Cells[6].Value.ToString().Trim() + "')";
                Funnction.Support.InitConnection(this.userName, this.password);
                Funnction.Support.RunSQL(sql);
                sql = "CALL admin.updateluong(,"+dataGridView1.Rows[x].Cells[0].Value.ToString()+")";
                Funnction.Support.RunSQL(sql);
                sql = "CALL admin.updateluong()";
                Funnction.Support.RunSQL(sql);
                Funnction.Support.Disconnect();
                loadData();
            }
            else
            {
                Funnction.Support.InitConnection(this.userName, this.password);
                sql = "CALL admin.update_luong(" + dataGridView1.Rows[x].Cells[7].Value.ToString() + "," + dataGridView1.Rows[x].Cells[0].Value.ToString() + ")";
                Funnction.Support.RunSQL(sql);
                sql = "CALL admin.update_phucap(" + dataGridView1.Rows[x].Cells[8].Value.ToString() + "," + dataGridView1.Rows[x].Cells[0].Value.ToString() + ")";
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
