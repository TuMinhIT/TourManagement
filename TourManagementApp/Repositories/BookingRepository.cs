using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;

namespace TourManagementApp.Repositories
{
    public interface BookingRepository
    {
        Booking GetById(int id);
        bool DeleteById(int id);
        bool AddNew(Booking booking);
        List<Booking> getAll();
        bool Update(Booking booking);
        public List<Booking> GetByAttribute(string attribute, string value);
        
    }
}
