using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;
namespace TourManagementApp.Services
{
    public interface UserService
   {
        string RegisterUser(Users user);
        List<Users> getAllUsers();
        Users UserAuth(string userId, string password);
        bool UpdateUser(Users user);
        Users GetById(string userId);
        Users GetByEmail(string Email);
        bool DeleteById(string userId);
    }
}
