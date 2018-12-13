using CarRentals.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;



namespace CarRentals.Repository.Interface
{
    public interface ICustomerRepository
    {
        
        void CreateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
        Customer GetCustomerById(int CustomerId);
        List<Customer> GetAllCustomer();
        void UpdateCustomer(int id, Customer customer);
       
    }

}
