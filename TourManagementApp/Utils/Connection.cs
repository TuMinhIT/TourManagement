using Microsoft.Data.SqlClient;
using TourManagementApp.Models;

namespace TourManagementApp.Database
{
    public class Connection
    {
        private static string db = @"LAPTOP-MR4HRVU5\SQLEXPRESS";
        private static readonly string baseConnectionString = $"Data Source={db};Integrated Security=True;Encrypt=False";  
        public static SqlConnection GetSqlConnection(string database)
        {
            string connectionString = $"{baseConnectionString};Initial Catalog={database};";
            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi kết nối đến cơ sở dữ liệu: {ex.Message}");
                return null;
            }
        }

        public static void CloseConnection(SqlConnection conn)
        {
            if (conn?.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                //Console.WriteLine("Kết nối đã được đóng.");
                MessageBox.Show("đóng rồi");
            }
        }
    }
}
