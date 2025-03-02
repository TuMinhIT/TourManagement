using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;

namespace TourManagementApp.Repositories
{
    public interface CustomerRepository
    {
        bool AddNew(Customer customer);
        List<Customer> getAll();
        bool Update(Customer customer);
        Customer GetById(string customerId);
        Customer GetByEmail(string Email);

        List<Customer> GetByAttribute(string attribute, string value);

        bool DeleteById(string customerId);
    }


}
