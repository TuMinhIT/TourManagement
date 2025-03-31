using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using TourManagementApp.Models;
using TourManagementApp.Database;

namespace TourManagementApp.Repositories.ImplRepositories
{
    public class ImplBookingRepository : BookingRepository
    {
        public bool AddNew(Booking booking)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string insertQuery = @"
                INSERT INTO CustomerTours (CustomerID, CustomerName, TourID, TourName, BookingDate,Status, TotalAmount, PrePay) 
                VALUES (@CustomerID,@CustomerName, @TourID,@TourName ,@BookingDate,@Status, @TotalAmount, @PrePay);";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", booking.CustomerID ?? "null");
                        cmd.Parameters.AddWithValue("@CustomerName", booking.CustomerName ?? "null");
                        cmd.Parameters.AddWithValue("@TourID", booking.TourID);
                        cmd.Parameters.AddWithValue("@TourName", booking.TourName);
                        cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                        cmd.Parameters.AddWithValue("@Status", booking.Status);
                        cmd.Parameters.AddWithValue("@TotalAmount", booking.TotalAmount);
                        cmd.Parameters.AddWithValue("@PrePay", booking.PrePay);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thêm order: {ex.Message}");
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
                    string query = "DELETE FROM CustomerTours WHERE BookingID = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Order này: " + ex.Message);
                    return false;
                }
            }
        }
        public List<Booking> getAll()
        {
            List<Booking> bookings = new List<Booking>();   
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }
                string query = "SELECT * FROM CustomerTours";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string customerID = reader.GetString(1);
                                string customerName = reader.GetString(2);
                                int tourID = reader.GetInt32(3);
                                string tourName = reader.GetString(4);
                                DateTime bookingDate = reader.GetDateTime(5);
                                string status = reader.GetString(6);
                                int total = reader.GetInt32(7);
                                int prepay = reader.GetInt32(8);

                                Booking newBooking = new Booking(customerID, customerName,tourID, tourName,bookingDate,
                                    status, prepay);
                                newBooking.BookingID = id;
                                bookings.Add(newBooking);
                            }
                        }
                        return bookings;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
            }
            return bookings;
        }
        public bool Update(Booking booking)
        {
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    string query = @"UPDATE CustomerTours SET                                   
                                  CustomerID = @CustomerID,CustomerName = @CustomerName ,TourID = @TourID, TourName = @TourName ,BookingDate = @BookingDate, Status = @Status, TotalAmount = @Total, PrePay = @PrePay
                              WHERE
                                  BookingID = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", booking.CustomerID);
                        cmd.Parameters.AddWithValue("@TourID", booking.TourID);

                        cmd.Parameters.AddWithValue("@CustomerName", booking.CustomerName);
                        cmd.Parameters.AddWithValue("@TourName", booking.TourName);

                        cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                        cmd.Parameters.AddWithValue("@Status", booking.Status);
                        cmd.Parameters.AddWithValue("@Total", booking.TotalAmount);
                        cmd.Parameters.AddWithValue("@PrePay", booking.PrePay);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi cập nhật booking: {ex.Message}");
                    return false;
                }
            }
        }
        public List<Booking> GetByAttribute(string attribute, string value)
        {
            List<Booking> list_booking = new List<Booking>();

            string query = $"SELECT * FROM CustomerTours WHERE {attribute} LIKE @value";

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
                                string customerID = reader.GetString(1);
                                string customerName = reader.GetString(2);
                                int tourID = reader.GetInt32(3);
                                string tourName = reader.GetString(4);
                                DateTime bookingDate = reader.GetDateTime(5);
                                string status = reader.GetString(6);
                                int total = reader.GetInt32(7);
                                int prepay = reader.GetInt32(8);

                                Booking newBooking = new Booking(customerID, customerName, tourID, tourName, bookingDate,
                                    status, prepay);
                                newBooking.BookingID = id;
                                list_booking.Add(newBooking);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return list_booking ;
        }

        public List<Booking> GetByBookingDate(DateTime bookingDate)
        {
            List<Booking> list_booking = new List<Booking>();

            string query = "SELECT * FROM CustomerTours WHERE CAST(BookingDate AS DATE) = @bookingDate";

            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@bookingDate", bookingDate.Date);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string customerID = reader.GetString(1);
                                string customerName = reader.GetString(2);
                                int tourID = reader.GetInt32(3);
                                string tourName = reader.GetString(4);
                                DateTime date = reader.GetDateTime(5);
                                string status = reader.GetString(6);
                                int total = reader.GetInt32(7);
                                int prepay = reader.GetInt32(8);

                                Booking newBooking = new Booking(customerID, customerName, tourID, tourName, date,
                                    status, prepay);
                                newBooking.BookingID = id;
                                list_booking.Add(newBooking);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
            return list_booking;
        }



        public Booking GetById(int id)
        {      
            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }
                string query = "SELECT * FROM CustomerTours WHERE BookingID = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {                      
                            while (reader.Read())
                            {
                                int bookingId = reader.GetInt32(0);
                                string customerID = reader.GetString(1);
                                string customerName = reader.GetString(2);
                                int tourID = reader.GetInt32(3);
                                string tourName = reader.GetString(4);
                                DateTime bookingDate = reader.GetDateTime(5);
                                string status = reader.GetString(6);
                                int total = reader.GetInt32(7);
                                int prepay = reader.GetInt32(8);

                                Booking newBooking = new Booking(customerID, customerName, tourID, tourName, bookingDate,
                                    status, total,prepay);
                                newBooking.BookingID = bookingId;

                                return newBooking;
                            }
                        }
                        return null;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
            }
            return null;
        }
    }
}
