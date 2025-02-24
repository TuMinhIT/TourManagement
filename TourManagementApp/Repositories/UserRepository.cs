using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;

namespace TourManagementApp.Repositories
{
    public interface UserRepository
    {
        string AddUser(Users user);
        List<Users> getAllUsers();
        Users UserAuth(string id, string pass);
        bool UpdateUser(Users user);
        Users GetById(string userId);
        Users GetByEmail(string Email);
        bool DeleteById(string userId);
    }
}
