using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagementApp.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Gender { get; set; }
        public string? PhoneNumber { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Nationality { get; set; }
        public string? Note { get; set; }

        public Customer(string fullName, string gender,string phone, string email,
                        string address, string nationality, string note) 
        { 
            this.FullName = fullName;
            this.Gender = gender;
            this.PhoneNumber = phone;
            this.Email = email;
            this.Address = address;
            this.Nationality = nationality;
            this.Note = note;
        }
        // Danh sách đơn đặt tour của khách hàng
        public List<Booking> Bookings { get; set; } = new();
    }

}
