using Microsoft.Data.SqlClient;

using TourManagementApp.Database;
using TourManagementApp.Models;

namespace TourManagementApp.Repositories.ImplRepositories
{
    public class ImplCustomerRepository:CustomerRepository
    {
        public bool AddNew(Customer customer)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {                  
                    string insertQuery = @"
                INSERT INTO Customers (FullName, Gender, PhoneNumber, Email, Address, Nationality, Notes) 
                VALUES (@FullName, @Gender, @Phone, @Email, @Address, @Nationality, @Notes );";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", customer.FullName ?? "null");
                        cmd.Parameters.AddWithValue("@Gender", customer.Gender ?? "null");
                        cmd.Parameters.AddWithValue("@Phone", customer.PhoneNumber ?? "null");
                        cmd.Parameters.AddWithValue("@Email", customer.Email ?? "null");
                        cmd.Parameters.AddWithValue("@Address", customer.Address ?? "null");
                        cmd.Parameters.AddWithValue("@Nationality", customer.Nationality ?? "null");
                        cmd.Parameters.AddWithValue("@Notes", customer.Note ?? "null");
                        
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm User: {ex.Message}");
                    return false;
                }
            }
        }
        public bool DeleteById(string CustomerID)
          {
              using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
              {
                  try
                  {
                      string query = "DELETE FROM Customers WHERE CustomerID = @Id";
                      using (SqlCommand cmd = new SqlCommand(query, conn))
                      {
                          cmd.Parameters.AddWithValue("@Id", CustomerID);

                          int rowsAffected = cmd.ExecuteNonQuery();
                          return rowsAffected > 0;
                      }
                  }
                  catch (Exception ex)
                  {
                      Console.WriteLine("Lỗi khi xóa customer: " + ex.Message);
                      return false;
                  }
              }
          }
        public List<Customer> getAll()
          {
              List<Customer> customers = new List<Customer>();
              using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
              {
                  if (conn == null)
                  {
                      MessageBox.Show("Kết nối dữ liệu thất bại!");
                      return null;
                  }
                  string query = "SELECT * FROM Customers";
                  using (SqlCommand cmd = new SqlCommand(query, conn))
                  {
                      try
                      {
                          using (SqlDataReader reader = cmd.ExecuteReader())
                          {
                              while (reader.Read())
                              {
                                  //Password, Role, FullName, Address, Phone, Email
                                  string id = reader.GetString(0);
                                  string fullname = reader.GetString(1);
                                  string Gender = reader.GetString(2);                                
                                  string phone = reader.GetString(3);
                                  string email = reader.GetString(4);
                                  string Address = reader.GetString(5);
                                  string nation = reader.GetString(6);
                                  string note = reader.GetString(7);

                                  Customer customer = new Customer(fullname, Gender,
                                      phone, email, Address, nation, note);
                                  customer.CustomerID = id;   
                                  customers.Add(customer);
                              }
                          }
                          return customers;

                      }
                      catch (Exception ex)
                      {
                          Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                      }
                  }
              }

              return customers;
          }

        public Customer GetByEmail(string Email)
          {
            Customer customer;
              using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
              {
                  try
                  {
                      string query = "SELECT * FROM Customers WHERE Email = @Email";
                      using (SqlCommand cmd = new SqlCommand(query, conn))
                      {
                          cmd.Parameters.AddWithValue("@Email", Email);
                          using (SqlDataReader reader = cmd.ExecuteReader())
                          {
                            while (reader.Read())
                            {
                                string id = reader.GetString(0);
                                string fullname = reader.GetString(1);
                                string Gender = reader.GetString(2);
                                string phone = reader.GetString(3);
                                string email = reader.GetString(4);
                                string Address = reader.GetString(5);
                                string nation = reader.GetString(6);
                                string note = reader.GetString(7);

                                customer = new Customer(fullname, Gender,
                                    phone, email, Address, nation, note);
                                customer.CustomerID = id;
                                return customer;
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

        public Customer GetById(string customerId)
          {
              Customer customer = null;
              using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
              {
                  try
                  {
                      string query = "SELECT * FROM Customers WHERE CustomerID = @Id";
                      using (SqlCommand cmd = new SqlCommand(query, conn))
                      {
                          cmd.Parameters.AddWithValue("@Id", customerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader.GetString(0);
                                string fullname = reader.GetString(1);
                                string Gender = reader.GetString(2);
                                string phone = reader.GetString(3);
                                string email = reader.GetString(4);
                                string Address = reader.GetString(5);
                                string nation = reader.GetString(6);
                                string note = reader.GetString(7);

                                customer = new Customer(fullname, Gender,
                                    phone, email, Address, nation, note);
                                customer.CustomerID = id;
                                return customer;
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

        public bool Update(Customer customer)
          {
              using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
              {
                  try
                  {
              
                       string query = @"UPDATE Customers SET                                   
                                  FullName = @name, Gender = @gender, PhoneNumber = @phone, Email = @email, Address = @address, Nationality = @nation, Notes = @note
                              WHERE
                                  CustomerID = @id";

                      using (SqlCommand cmd = new SqlCommand(query, conn))
                      {
                            cmd.Parameters.AddWithValue("@name", customer.FullName ?? "null");
                            cmd.Parameters.AddWithValue("@gender", customer.Gender ?? "null");
                            cmd.Parameters.AddWithValue("@phone", customer.PhoneNumber ?? "null");
                            cmd.Parameters.AddWithValue("@email", customer.Email ?? "null");
                            cmd.Parameters.AddWithValue("@address", customer.Address ?? "null");
                            cmd.Parameters.AddWithValue("@nation", customer.Nationality ?? "null");
                            cmd.Parameters.AddWithValue("@note", customer.Note ?? "null");
                            cmd.Parameters.AddWithValue("@id", customer.CustomerID);

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

        public List<Customer> getByName(string name)
        {         
            List<Customer> list_customer = new List<Customer>();
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = "SELECT * FROM Customers WHERE FullName COLLATE SQL_Latin1_General_CP1_CI_AI LIKE N'%@name%';";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader.GetString(0);
                                string fullname = reader.GetString(1);
                                string Gender = reader.GetString(2);
                                string phone = reader.GetString(3);
                                string email = reader.GetString(4);
                                string Address = reader.GetString(5);
                                string nation = reader.GetString(6);
                                string note = reader.GetString(7);

                                Customer customer = new Customer(fullname, Gender,
                                    phone, email, Address, nation, note);
                                customer.CustomerID = id;
                               list_customer.Add(customer);
                            }
                        }
                    }
                    return list_customer;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }

        }

        public List<Customer> GetByAttribute(string attribute, string value)
        {
            List<Customer> list_customer = new List<Customer>();

            string query = $"SELECT * FROM Customers WHERE {attribute} COLLATE SQL_Latin1_General_CP1_CI_AI LIKE @value";

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
                                string id = reader.GetString(0);
                                string fullname = reader.GetString(1);
                                string gender = reader.GetString(2);
                                string phone = reader.IsDBNull(3) ? null : reader.GetString(3);
                                string email = reader.IsDBNull(4) ? null : reader.GetString(4);
                                string address = reader.IsDBNull(5) ? null : reader.GetString(5);
                                string nationality = reader.IsDBNull(6) ? null : reader.GetString(6);
                                string note = reader.IsDBNull(7) ? null : reader.GetString(7);

                                Customer customer = new Customer(fullname, gender, phone, email, address, nationality, note)
                                {
                                    CustomerID = id
                                };
                                list_customer.Add(customer);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return list_customer;
        }

    }
}
