using System;

using TourManagementApp.Models;

namespace TourManagementApp.Services
{
    public interface TourService
    {
        bool AddNew(Tours tour);
        List<Tours> getAll();
        bool Update(Tours tour);   
        List<Tours> GetByPrice(int price_min, int price_max);
        bool DeleteById(int Id);
        public List<Tours> GetByAttribute(string attribute, string value);
    }
}
