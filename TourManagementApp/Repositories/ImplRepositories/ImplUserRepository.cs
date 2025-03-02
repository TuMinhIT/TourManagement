using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TourManagementApp.Database;
using TourManagementApp.Models;
using TourManagementApp.Services.ImplServices;
using TourManagementApp.Services;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TourManagementApp.Repositories.ImplRepositories
{
    class ImplUserRepository : UserRepository
    {

        public string AddUser(Users user)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string insertQuery = @"
                INSERT INTO Users (Password, Role, FullName, Address, Phone, Email, note) 
                VALUES (@Password, @Role, @FullName, @Address, @Phone, @Email, @note );";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", user.Password ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Role", user.Role ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@FullName", user.FullName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Address", user.Address ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Phone", user.Phone ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", user.Email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@note", user.note ?? (object)DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    // Truy vấn lấy ID theo Email
                    string selectQuery = "SELECT UserID FROM Users WHERE Email = @Email;";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        string result = cmd.ExecuteScalar().ToString();
                        return result;
                    }
                    return "null";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi khi thêm User: {ex.Message}");
                    return "null";
                }
            }
        }
        public bool DeleteById(string userId)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                { 
                    string query = "DELETE FROM Users WHERE UserID = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", userId);

                        int rowsAffected = cmd.ExecuteNonQuery(); 
                        return rowsAffected > 0; 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi xóa user: " + ex.Message);
                    return false; 
                }
            }
        }
        public List<Users> getAllUsers()
        {           
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {             
                if (conn == null)
                {
                    MessageBox.Show("Kết nối thất bại!");
                    return null;
                }
                List<Users> users = new List<Users>();
                string query = "SELECT * FROM Users";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string UserID = reader["UserID"].ToString();
                                string FullName = reader["FullName"].ToString();
                                string Role = reader["Role"].ToString();
                                string Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null;
                                string Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : null;
                                string Email = reader["Email"].ToString();
                                string link = reader["link"].ToString();
                                string note = reader["note"].ToString();                                                           
                                Users user1 = new Users(" ", " ", FullName, Address, Phone, Email, note);
                                user1.UserID = UserID;
                                users.Add(user1);
                                
                            }
                        }
                        return users;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
                return users;
            }
          
        }
        
        public Users GetByEmail(string Email)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = "SELECT UserID, FullName, Role, Address, Phone, Email, link, note FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", Email);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Users
                                {
                                    UserID = reader["UserID"].ToString(),
                                    FullName = reader["FullName"].ToString(),
                                    Role = reader["Role"].ToString(),
                                    Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null,
                                    Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : null,
                                    Email = reader["Email"].ToString(),
                                    link = reader["link"].ToString(),
                                    note = reader["note"].ToString(),
                                };
                            }
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public Users GetById(string userId)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = "SELECT UserID, FullName, Role, Address, Phone, Email, link, note FROM Users WHERE UserID = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Users
                                {
                                    UserID = reader["UserID"].ToString(),
                                    FullName = reader["FullName"].ToString(),
                                    Role = reader["Role"].ToString(),
                                    Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null,
                                    Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : null,
                                    Email = reader["Email"].ToString(),
                                    link = reader["link"].ToString(),
                                    note = reader["note"].ToString()
                                };
                            }
                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public bool UpdateUser(Users user)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = @"UPDATE Users SET                                   
                            FullName = @name,
                            Address = @address,
                            Phone = @phone,
                            link = @link,
                            note = @note
                        WHERE
                            UserID = @id AND Email = @email";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", user.FullName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@address", user.Address ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@phone", user.Phone ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@link", user.link );
                        cmd.Parameters.AddWithValue("@note", user.note);

                        cmd.Parameters.AddWithValue("@id", user.UserID);
                        cmd.Parameters.AddWithValue("@email", user.Email);
                        
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật User: {ex.Message}");
                    return false;
                }
            }
        }
      
        public Users UserAuth(string id, string pass)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = "SELECT UserID, FullName, Role, Address, Phone, Email, Password, note, link FROM Users WHERE UserID = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashedPassword = reader["Password"].ToString();

                                if (BCrypt.Net.BCrypt.Verify(pass, hashedPassword))
                                {
                                    return new Users
                                    {
                                        UserID = reader["UserID"].ToString(),
                                        FullName = reader["FullName"].ToString(),
                                        Role = reader["Role"].ToString(),
                                        Address = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : null,
                                        Phone = reader["Phone"] != DBNull.Value ? reader["Phone"].ToString() : null,
                                        Email = reader["Email"].ToString(),
                                        link = reader["link"].ToString(),
                                        note = reader["note"].ToString(),
                                    };
                                }
                            }

                        }
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }

            }
        }
    }
}
