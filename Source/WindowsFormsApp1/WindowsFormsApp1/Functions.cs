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

        [Obsolete]
        public static string InitConnection(String username, String password)
        {
            String connectionString = @"Data Source=" + host_name + ";User ID=" + username + ";Password=" + password + "";

            Connect = new OracleConnection();
            Connect.ConnectionString = connectionString;
            string res = "";
            try
            {
                //Mở kết nối
                Connect.Open();

            }
            catch (OracleException ex)
            {
                Connect = null;
                MessageBox.Show(ex.Message);
                res = ex.Message;
            }
            return res;
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

        public static void RunSQL(string sql)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Connect;
            cmd.CommandText= sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        public static string GetFieldValues(String sql)
        {
            string ma = "";
            OracleCommand cmd = new OracleCommand(sql, Connect);
            OracleDataReader reader= cmd.ExecuteReader();
            while(reader.Read())
            {
                ma=reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}
