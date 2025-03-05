
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;

namespace TourManagementApp.Services
{
     public interface BookingService
     {
        Booking GetByID(int id);
        bool AddNew(Booking booking);
        List<Booking> getAll();
        bool Update(Booking booking);
        bool DeleteById(int ID);
        public List<Booking> GetByAttribute(string attribute, string value); 
    }
}
