using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagementApp.Models;
using TourManagementApp.Repositories.ImplRepositories;
using TourManagementApp.Repositories;

namespace TourManagementApp.Services.ImplServices
{
    public class ImplCustomerService : CustomerService
    {

        private CustomerRepository _customerRepository;
        public ImplCustomerService()
        {
            _customerRepository = new ImplCustomerRepository();  // a implement
        }
        public bool AddNew(Customer customer)
        {
           return _customerRepository.AddNew(customer);
        }

        public bool DeleteById(string customerId)
        {
            return _customerRepository.DeleteById(customerId);
        }

        public List<Customer> getAllCustomer()
        {
            return _customerRepository.getAll();
        }

        public Customer GetByEmail(string Email)
        {
            return _customerRepository.GetByEmail(Email);
        }

        public Customer GetById(string customerId)
        {
            return _customerRepository.GetById(customerId);
        }

        public List<Customer> GetByName(string name)
        {
            return _customerRepository.GetByAttribute("FullName", name);
        }

        public List<Customer> GetByAddess(string address)
        {
            return _customerRepository.GetByAttribute("Address", address);
        }

        public List<Customer> GetByPhone(string phone)
        {
            return _customerRepository.GetByAttribute("PhoneNumber", phone);
        }

        public bool Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
    }
}
