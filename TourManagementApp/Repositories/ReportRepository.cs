using Microsoft.Data.SqlClient;
using System;
using TourManagementApp.Models;
using TourManagementApp.Database;
namespace TourManagementApp.Repositories
{
    public class ReportRepository
    {
        public Dictionary<string, int> GetTourTypeCounts()
        {
            Dictionary<string, int> tourTypeCounts = new Dictionary<string, int>();

            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }

                string query = "SELECT TourType, COUNT(*) AS TotalTours FROM Tours  GROUP BY TourType";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                    

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string tourType = reader.GetString(0); 
                                int count = reader.GetInt32(1); 

                                tourTypeCounts.Add(tourType, count); 
                            }
                        }
                        return tourTypeCounts;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
            }
            return null;
        }

        public Dictionary<int, int> GetTotalAmountByMonth(int year)
        {
            Dictionary<int, int> revenueByMonth = new Dictionary<int, int>();

            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return null;
                }

                //string query = @"
                //        SELECT MONTH(Day_End) AS Month, SUM(TotalAmount) AS Revenue
                //        FROM Schedule
                //        WHERE YEAR(Day_End) = @Year
                //        GROUP BY MONTH(Day_End)";
                string query = @"
                SELECT MONTH(Day_End) AS Month, SUM(TotalAmount) AS Revenue
                FROM Schedule
                WHERE YEAR(Day_End) = @Year
                  AND Status_Pay = 'Completed'
                GROUP BY MONTH(Day_End)";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@Year", year);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int month = reader.GetInt32(0); // Tháng
                                int totalAmount = reader.GetInt32(1); // Tổng doanh thu

                                if (!revenueByMonth.ContainsKey(month))
                                {
                                    revenueByMonth.Add(month, totalAmount);
                                }
                            }
                        }
                        return revenueByMonth;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
            }
            return null;
        }


        public Dictionary<string, int> GetStatistics(DateTime startDate, DateTime endDate)
        {
            Dictionary<string, int> statistics = new Dictionary<string, int>
                {
                    { "TotalRevenue", 0 },
                    { "TotalTours", 0 },
                    { "PaidTours", 0 },
                    { "UnpaidTours", 0 }
                };

            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return statistics;
                }

                string query = @"
            SELECT 
                SUM(TotalAmount) AS TotalRevenue, 
                COUNT(DISTINCT TourID) AS TotalTours,
                COUNT(CASE WHEN Status_Pay = 'Completed' THEN 1 END) AS PaidTours,
                COUNT(CASE WHEN Status_Pay = 'Booked' THEN 1 END) AS UnpaidTours
            FROM Schedule
            WHERE Day_End BETWEEN @StartDate AND @EndDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                statistics["TotalRevenue"] = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                                statistics["TotalTours"] = reader.IsDBNull(1) ? 0 : reader.GetInt32(1);
                                statistics["PaidTours"] = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                                statistics["UnpaidTours"] = reader.IsDBNull(3) ? 0 : reader.GetInt32(3);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lấy dữ liệu ở statis: {ex.Message}");
                    }
                }
            }
            return statistics;
        }

        public List<Schedule> GetSchedule(DateTime startDate, DateTime endDate)
        {
            List<Schedule> schedules = new List<Schedule>();

            using (SqlConnection conn = Connection.GetSqlConnection(DatabaseName.TourManagement.ToString()))
            {
                if (conn == null)
                {
                    MessageBox.Show("Kết nối dữ liệu thất bại!");
                    return schedules;
                }

                string query = @"
                    SELECT ScheduleID,TourID , TourName, CustomerName, Status_Pay, TotalAmount
                    FROM Schedule
                    WHERE Day_End BETWEEN @StartDate AND @EndDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int scheduleID = reader.GetInt32(0);
                                int tourID = reader.GetInt32(1);
                                string tourName = reader.GetString(2);            
                                string? customerName = reader.IsDBNull(3) ? null : reader.GetString(3); 
                                string? statusPay = reader.IsDBNull(4) ? null : reader.GetString(4);
                                int total = reader.GetInt32(5);
           
                                Schedule Newschedule = new Schedule(tourID, tourName, "none", customerName, DateTime.Now, DateTime.Now, statusPay, total, "description");
                                Newschedule.ScheduleID = scheduleID;
                              
                                schedules.Add(Newschedule);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi lấy dữ liệu: {ex.Message}");
                    }
                }
            }
            return schedules;
        }



    }
}
