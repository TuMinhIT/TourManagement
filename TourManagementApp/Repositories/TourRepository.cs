using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;

namespace TourManagementApp.Repositories
{
    public interface TourRepository
    {
        bool AddNew(Tours tour);
        List<Tours> getAll();
        bool Update(Tours tour);
        //Tours GetById(int id);
        List<Tours> GetByPrice(int price_min, int price_max);
        bool DeleteById(int Id);
        public List<Tours> GetByAttribute(string attribute, string value);
    }
}
