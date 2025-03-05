using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagementApp.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string CustomerID { get; set; }
        public string CustomerName{ get; set; }
        public int TourID { get; set; }
        public string TourName { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Booked"; // Deposited, Completed, Canceled
        public int TotalAmount { get; set; }
        public int PrePay {  get; set; }   

 
        public Booking( string customerID,string customerName, int tourID, string tourName ,DateTime bookingDate , string status, int totalAmount = 0, int prePay = 0)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            TourID = tourID;
            TourName = tourName;
            BookingDate = bookingDate;
            Status = status;
            TotalAmount = totalAmount;
            PrePay = prePay;
        }
    }

}
