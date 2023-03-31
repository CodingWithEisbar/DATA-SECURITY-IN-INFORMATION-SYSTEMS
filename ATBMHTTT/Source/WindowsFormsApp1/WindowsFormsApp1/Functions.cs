using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funnction
{
    public class Support
    {
        [Obsolete]
        public static OracleConnection Connect;
        private static string host_name = System.Windows.Forms.SystemInformation.ComputerName;
        //private static string host_name = @"DESKTOP-9QUAAMR";

        [Obsolete]
        public static void InitConnection(String username, String password)
        {
            String connectionString = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            Connect = new OracleConnection();
            Connect.ConnectionString = connectionString;

            try
            {
                //Mở kết nối
                Connect.Open();

                ////Kiểm tra kết nối
                if (Connect.State == ConnectionState.Open)
                {
                    MessageBox.Show("Kết nối DB thành công");
                }

            }
            catch (OracleException ex)
            {
                Connect = null;
                throw new Exception(ex.Message);
            }
        }

        [Obsolete]
        public static void Disconnect()
        {
            if (Connect.State == ConnectionState.Open)
            {
                //Đóng kết nối
                Connect.Close();

                //Giải phóng tài nguyên
                Connect.Dispose();
                Connect = null;

                //MessageBox.Show("Đóng kết nối với DB");
            }
        }

        [Obsolete]
        public static DataTable GetDataToTable(string sql)
        {
            OracleCommand command = new OracleCommand();
            command.CommandText=sql;
            command.Connection = Connect;
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
