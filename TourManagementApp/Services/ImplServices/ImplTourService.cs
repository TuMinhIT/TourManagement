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
    public class ImplTourService : TourService
    {
        public ImplTourService() { }
        private TourRepository _tourRepository= new ImplTourRepository();
        public bool AddNew(Tours tour)
        {
            return _tourRepository.AddNew(tour);
        }

        public bool DeleteById(int Id)
        {
            return _tourRepository.DeleteById(Id);
        }

        public List<Tours> getAll()
        {
            return _tourRepository.getAll();
        }


        public List<Tours> GetByPrice(int price_min, int price_max)
        {
            return _tourRepository.GetByPrice(price_min, price_max);
        }

        public bool Update(Tours tour)
        {
            return _tourRepository.Update(tour);
        }

        public List<Tours> GetByAttribute(string attribute, string value)
        {
            return _tourRepository.GetByAttribute(attribute, value);
        }

     
    }
}
