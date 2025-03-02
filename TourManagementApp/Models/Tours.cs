using System;
using TourManagementApp.Models;
namespace TourManagementApp.Models
{
    public class Tours
    {
        public int TourID { get; set; }
        public string TourName { get; set; } = string.Empty;
        public string TourType { get; set; } = string.Empty; // Luxury, Standard, Budget
        public string Transport { get; set; } = string.Empty; // Car, Airplane
        public string Price { get; set; }
        public string? LinkImage { get; set; }
        public string? Description { get; set; }
        
        public Tours(string name, string type, string transport, string price, string link, string des ) { 
            this.TourName = name;
            this.TourType = type;
            this.Transport = transport; 
            this.Price = price;
            this.LinkImage = link;
            this.Description = des;
        }
        public Tours() { }   

        // Quan hệ 1-N với Booking và Schedule
        public List<Booking> Bookings { get; set; } = new();
        public List<Schedule> Schedules { get; set; } = new();
    }

}
