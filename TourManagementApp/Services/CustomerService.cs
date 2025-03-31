using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;

namespace TourManagementApp.Services
{
    public interface CustomerService
    {
        bool AddNew(Customer customer);
        List<Customer> getAllCustomer();    
        bool Update(Customer customer);
        Customer GetById(string customerId);
        Customer GetByEmail(string Email);
        List<Customer> GetByPhone(string customerId);
        List<Customer> GetByAddess(string Email);
        List<Customer> GetByName(string Email);
        bool DeleteById(string customerId);
       
    }
}
