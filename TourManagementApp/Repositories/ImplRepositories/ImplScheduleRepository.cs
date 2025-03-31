using Microsoft.Data.SqlClient;
using TourManagementApp.Database;
using TourManagementApp.Models;

namespace TourManagementApp.Repositories.ImplRepositories
{
    public class ImplScheduleRepository: ScheduleRepository
    {
        public bool AddNew(Schedule schedule)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string insertQuery = @"
                        INSERT INTO Schedule (TourID, TourName, CustomerID, CustomerName, Day_Start, Day_End, Status_Pay, TotalAmount, Description) 
                        VALUES (@TourID, @TourName, @CustomerID, @CustomerName, @Day_Start, @Day_End, @Status_Pay,@TotalAmount ,@Description);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@TourID", schedule.TourID);
                        cmd.Parameters.AddWithValue("@TourName", schedule.TourName ?? "null");
                        cmd.Parameters.AddWithValue("@CustomerID", schedule.CustomerID ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@CustomerName", schedule.CustomerName ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Day_Start", schedule.Day_Start);
                        cmd.Parameters.AddWithValue("@Day_End", schedule.Day_End);
                        cmd.Parameters.AddWithValue("@Status_Pay", schedule.Status_pay ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@TotalAmount", schedule.Total);
                        cmd.Parameters.AddWithValue("@Description", schedule.Description ?? "null");

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                    string query = "DELETE FROM Schedule WHERE ScheduleID = @Id"; 
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Schedule: " + ex.Message);
                    return false;
                }
            }
        }
        public List<Schedule> getAll()
        {
            List<Schedule> list_schedule = new List<Schedule>();
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }
                string query = "SELECT * FROM Schedule";      
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {              
                                int scheduleID = reader.GetInt32(0);
                                int tourID = reader.GetInt32(1);
                                string tourName = reader.GetString(2);
                                string? customerID = reader.IsDBNull(3) ? null : reader.GetString(3);
                                string? customerName = reader.IsDBNull(4) ? null : reader.GetString(4);
                                DateTime dayStart = reader.GetDateTime(5);
                                DateTime dayEnd = reader.GetDateTime(6);
                                string? statusPay = reader.IsDBNull(7) ? null : reader.GetString(7);
                                int total = reader.GetInt32(8);
                                string description = reader.GetString(9);
                           
                                Schedule schedule = new Schedule( tourID, tourName, customerID, customerName, dayStart, dayEnd, statusPay,total, description);
                                schedule.ScheduleID = scheduleID;
                                list_schedule.Add(schedule);
                            }
                        }
                        return list_schedule;

                    }            
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
            }
            return null;
        }
        public bool Update(Schedule schedule)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = @"
                            UPDATE Schedule SET                                                                                                             
                                Day_Start = @DayStart,
                                Day_End = @DayEnd, 
                                Status_Pay = @StatusPay, 
                                Description = @Description
                            WHERE
                                ScheduleID = @ScheduleID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {                  
                        cmd.Parameters.AddWithValue("@DayStart", schedule.Day_Start);
                        cmd.Parameters.AddWithValue("@DayEnd", schedule.Day_End);
                        cmd.Parameters.AddWithValue("@StatusPay", schedule.Status_pay ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", schedule.Description);
                        cmd.Parameters.AddWithValue("@ScheduleID", schedule.ScheduleID);

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
        public Schedule GetById(int id)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }
                string query = "SELECT * FROM Schedule WHERE ScheduleID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int scheduleID = reader.GetInt32(0);
                                int tourID = reader.GetInt32(1);
                                string tourName = reader.GetString(2);
                                string? customerID = reader.IsDBNull(3) ? null : reader.GetString(3);
                                string? customerName = reader.IsDBNull(4) ? null : reader.GetString(4);
                                DateTime dayStart = reader.GetDateTime(5);
                                DateTime dayEnd = reader.GetDateTime(6);
                                string? statusPay = reader.IsDBNull(7) ? null : reader.GetString(7);
                                int total = reader.GetInt32(8);
                                string description = reader.GetString(9);

                            
                                Schedule schedule = new Schedule(tourID, tourName, customerID, customerName, dayStart, dayEnd, statusPay, total, description);
                                schedule.ScheduleID = scheduleID;   
                                return schedule;
                            }
                        }
                        return null; 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
                        return null;
                    }
                }

            }
         
        }

        public Schedule getByTourID(int tour, string customer)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }
                string query = "SELECT * FROM Schedule WHERE TourID = @Id AND CustomerID =@IDcus";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", tour);
                        cmd.Parameters.AddWithValue("@IDcus", customer);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int scheduleID = reader.GetInt32(0);
                                int tourID = reader.GetInt32(1);
                                string tourName = reader.GetString(2);
                                string? customerID = reader.IsDBNull(3) ? null : reader.GetString(3);
                                string? customerName = reader.IsDBNull(4) ? null : reader.GetString(4);
                                DateTime dayStart = reader.GetDateTime(5);
                                DateTime dayEnd = reader.GetDateTime(6);
                                string? statusPay = reader.IsDBNull(7) ? null : reader.GetString(7);
                                int total = reader.GetInt32(8);
                                string description = reader.GetString(9);


                                Schedule schedule = new Schedule(tourID, tourName, customerID, customerName, dayStart, dayEnd, statusPay,total, description);
                                schedule.ScheduleID = scheduleID;
                                return schedule;
                            }
                        }
                        return null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
                        return null;
                    }
                }

            }
        }
    }
}
