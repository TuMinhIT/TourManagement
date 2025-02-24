using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TourManagementApp.Models
{

    public class Users
    {

        public Users() { }   

        public Users(string pass, string role, string name, string address, string phone, string email) { 
            this.Password = pass;
            this.Role = role;
            this.FullName = name;   
            this.Address = address; 
            this.Phone = phone;
            this.Email = email;
        }

        public string? UserID { get; set; }
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty; // Admin, Staff
        public string FullName { get; set; } = string.Empty;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; } = string.Empty;
        public string link { get; set; } 
    }
}
