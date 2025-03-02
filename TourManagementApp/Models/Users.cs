using System;
using System.Collections.Generic;

namespace TourManagementApp.Models
{

    public class Users
    {
        public Users() { }   

        public string? UserID { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // Admin, Staff
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; }
        public string Email { get; set; }
        public string link { get; set; } = string.Empty;
        public string? note { get; set; } = string.Empty;

        public Users(string pass, string role, string name, string address = "null", string phone="null", string email = "null", string note= "null")
        {
            this.Password = pass;
            this.Role = role;
            this.FullName = name;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.note = note;
        }

    }
}
