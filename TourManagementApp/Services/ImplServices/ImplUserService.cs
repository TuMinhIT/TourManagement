
using TourManagementApp.Repositories.ImplRepositories;
using TourManagementApp.Repositories;
using TourManagementApp.Models;
using BCrypt.Net;
using Microsoft.VisualBasic.ApplicationServices;
namespace TourManagementApp.Services.ImplServices
{
    class ImplUserService : UserService
    {
        private UserRepository _userRepository;
        public ImplUserService()
        {
            _userRepository = new ImplUserRepository(); // a implement
        }

        public string RegisterUser(Users user)
        {
            string pw = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Password = pw;

            return _userRepository.AddUser(user);
        }

        public List<Users> getAllUsers()
        {
            return _userRepository.getAllUsers();
        }

        public Users UserAuth(string userId, string password)
        {
            return _userRepository.UserAuth(userId, password);
        }

        public bool UpdateUser(Users user)
        {
            return _userRepository.UpdateUser(user);
        }

        public Users GetById(string userId)
        {
            return _userRepository.GetById(userId);
        }

        public Users GetByEmail(string Email)
        {
            return _userRepository.GetByEmail(Email);
        }

        public bool DeleteById(string userId)
        {
            return _userRepository.DeleteById(userId);
        }

        public bool changePassword(Users user)
        {
            string pw = BCrypt.Net.BCrypt.HashPassword(user.Password);
            user.Password = pw;
            return _userRepository.changePassword(user);
        }
    }   
}
