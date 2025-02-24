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
        public int CustomerID { get; set; }
        public int TourID { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Deposited"; // Deposited, Completed, Canceled
        public decimal TotalAmount { get; set; }

        // Navigation properties
        public Customer Customer { get; set; } = null!;
        public Tour Tour { get; set; } = null!;
    }

}
