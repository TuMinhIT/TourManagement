using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;
using TourManagementApp.Repositories;
using TourManagementApp.Repositories.ImplRepositories;

namespace TourManagementApp.Services.ImplServices
{
    public class ImplBookingService : BookingService

    {
        private BookingRepository _bookingRepository = new ImplBookingRepository();
        public bool AddNew(Booking booking)
        {
            return _bookingRepository.AddNew(booking);
        }

        public bool DeleteById(int ID)
        {
            return _bookingRepository.DeleteById(ID);
        }

        public List<Booking> getAll()
        {
            return _bookingRepository.getAll();
        }

        public List<Booking> GetByAttribute(string attribute, string value)
        {
            return _bookingRepository.GetByAttribute(attribute, value);
        }

        public Booking GetByID(int id)
        {
            return _bookingRepository.GetById(id);
        }

        public bool Update(Booking booking)
        {
            return _bookingRepository.Update(booking);
        }

        public List<Booking> GetByBookingDate(DateTime bookingDate)
        {
            return _bookingRepository.GetByBookingDate(bookingDate);
        }
    }
}
