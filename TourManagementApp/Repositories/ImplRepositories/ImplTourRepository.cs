using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TourManagementApp.Database;
using TourManagementApp.Models;

namespace TourManagementApp.Repositories.ImplRepositories
{
    public class ImplTourRepository:TourRepository
    {
        public bool AddNew(Tours tour)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string insertQuery = @"
                INSERT INTO Tours (TourName, TourType, Transport, Price, LinkImage, Description) 
                VALUES (@TourName, @TourType, @Transport, @Price, @LinkImage, @Des);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TourName", tour.TourName ?? "null");
                        cmd.Parameters.AddWithValue("@TourType", tour.TourType ?? "null");
                        cmd.Parameters.AddWithValue("@Transport", tour.Transport ?? "null");
                        cmd.Parameters.AddWithValue("@Price", tour.Price);
                        cmd.Parameters.AddWithValue("@LinkImage", tour.LinkImage);
                        cmd.Parameters.AddWithValue("@Des", tour.Description ?? "null");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm Tour: {ex.Message}");
                    return false;
                }
            }
        }
        public bool DeleteById(int id)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = "DELETE FROM Tours WHERE TourID = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Tour: " + ex.Message);
                    return false;
                }
            }
        }
        public List<Tours> getAll()
        {
            List<Tours> tours = new List<Tours>();
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }
                string query = "SELECT * FROM Tours";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {      
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string type = reader.GetString(2);
                                string transport = reader.GetString(3);
                                string price = reader.GetString(4);
                                string link = reader.GetString(5);
                                string des = reader.GetString(6);
                            
                                Tours tour1 = new Tours(name, type, transport, price, link, des);
                                tour1.TourID = id;
                                tours.Add(tour1);
                            }
                        }
                        return tours;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
            }
            return tours;
        } 
        public bool Update(Tours tour)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {

                    string query = @"UPDATE Tours SET                                   
                                  TourName = @TourName, TourType= @TourType, Transport = @Transport, Price = @Price, LinkImage = @link, Description = @des
                              WHERE
                                  TourID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TourName", tour.TourName);
                        cmd.Parameters.AddWithValue("@TourType", tour.TourType);
                        cmd.Parameters.AddWithValue("@Transport", tour.Transport);
                        cmd.Parameters.AddWithValue("@Price", tour.Price);
                        cmd.Parameters.AddWithValue("@link", tour.LinkImage);
                        cmd.Parameters.AddWithValue("@des", tour.Description);
                        cmd.Parameters.AddWithValue("@id", tour.TourID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật Tour: {ex.Message}");
                    return false;
                }
            }
        }
        public List<Tours> GetByAttribute(string attribute, string value)
        {
            List<Tours> list_tour = new List<Tours>();

            string query = $"SELECT * FROM Tours WHERE {attribute} LIKE @value";

            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@value", $"%{value}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string type = reader.GetString(2);
                                string transport = reader.GetString(3);
                                string price = reader.GetString(4);
                                string link = reader.GetString(5);
                                string des = reader.GetString(6);

                                Tours tour1 = new Tours(name, type, transport, price, link, des);
                                tour1.TourID = id;
                                list_tour.Add(tour1);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return list_tour;
        }

        public List<Tours> GetByPrice(int price_min, int price_max)
        {
            List<Tours> list_tour = new List<Tours>();

            string query = "SELECT * FROM Tours WHERE TRY_CAST(Price AS INT) > @MinPrice AND TRY_CAST(Price AS INT) < @MaxPrice;";

            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MinPrice", price_min);
                        cmd.Parameters.AddWithValue("@MaxPrice", price_max);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string type = reader.GetString(2);
                                string transport = reader.GetString(3);
                                string price = reader.GetString(4);
                                string link = reader.GetString(5);
                                string des = reader.GetString(6);

                                Tours tour1 = new Tours(name, type, transport, price, link, des);
                                tour1.TourID = id;
                                list_tour.Add(tour1);
                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return list_tour;
        }
    }
}
