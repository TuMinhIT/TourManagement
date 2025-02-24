using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;
namespace TourManagementApp.Models
{
    public class Tour
    {
        public int TourID { get; set; }
        public string TourName { get; set; } = string.Empty;
        public string TourType { get; set; } = string.Empty; // Luxury, Standard, Budget
        public string Transport { get; set; } = string.Empty; // Car, Airplane
        public decimal Price { get; set; }
        public string? Description { get; set; }

        // Quan hệ 1-N với Booking và Schedule
        public List<Booking> Bookings { get; set; } = new();
        public List<Schedule> Schedules { get; set; } = new();
    }

}
