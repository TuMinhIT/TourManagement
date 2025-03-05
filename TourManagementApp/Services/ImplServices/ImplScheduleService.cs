using System;
using TourManagementApp.Models;
using TourManagementApp.Repositories;
using TourManagementApp.Repositories.ImplRepositories;

namespace TourManagementApp.Services.ImplServices
{
    public class ImplScheduleService : ScheduleService
    {
        private readonly ScheduleRepository _scheduleRepository = new
            ImplScheduleRepository();
        public bool AddNew(Schedule schedule)
        {
            return _scheduleRepository.AddNew(schedule);
        }

        public bool DeleteById(int Id)
        {
            return _scheduleRepository.DeleteById(Id);
        }

        public List<Schedule> getAll()
        {
            return _scheduleRepository.getAll();    
        }

        public Schedule GetById(int id)
        {
            return _scheduleRepository.GetById(id);
        }

        public Schedule getByTourID(int tourID, string customerID)
        {
           return _scheduleRepository.getByTourID(tourID, customerID);
        }

        public bool Update(Schedule schedule)
        {
            return _scheduleRepository.Update(schedule);
        }
    }
}
