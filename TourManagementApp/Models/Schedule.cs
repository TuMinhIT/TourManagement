using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagementApp.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public int TourID { get; set; }
        public string TourName { get; set; } = string.Empty;
        public string? CustomerID { get; set; }
        public string? CustomerName { get; set; }
        public DateTime Day_Start { get; set; }
        public DateTime Day_End { get; set; }
        public string? Status_pay { get; set; }
        public int Total {  get; set; } 
        public string Description { get; set; } = string.Empty;
       
        public Schedule(int tourID, string tourName, string? customerID, string? customerName,
                        DateTime dayStart, DateTime dayEnd, string? statusPay,int total, string description)
        {
            TourID = tourID;
            TourName = tourName;
            CustomerID = customerID;
            CustomerName = customerName;
            Day_Start = dayStart;
            Day_End = dayEnd;
            Status_pay = statusPay;
            Total = total;
            Description = description;
        }

        public Schedule(int id,int tourID, string tourName, string? customerID, string? customerName,
                        DateTime dayStart, DateTime dayEnd, string? statusPay, int total, string description)
        {
            ScheduleID = id;
            TourID = tourID;
            TourName = tourName;
            CustomerID = customerID;
            CustomerName = customerName;
            Day_Start = dayStart;
            Day_End = dayEnd;
            Status_pay = statusPay;
            Total = total;
            Description = description;
        }
    }
}