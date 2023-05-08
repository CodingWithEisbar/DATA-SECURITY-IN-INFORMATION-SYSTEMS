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
    public partial class ThongTinTruongDeAn : Form
    {
        string username;
        string password;
        public ThongTinTruongDeAn()
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void loadData ()
        {
            string sql_query = "SELECT * FROM DEAN WHERE ";
        }
    }
}
