using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;

namespace TourManagementApp.Services
{
    public interface ScheduleService
    {
        bool AddNew(Schedule schedule);
        List<Schedule> getAll();
        bool Update(Schedule schedule);
        Schedule GetById(int id);
        bool DeleteById(int Id);
        Schedule getByTourID(int tourID, string customerID);
    }
}
