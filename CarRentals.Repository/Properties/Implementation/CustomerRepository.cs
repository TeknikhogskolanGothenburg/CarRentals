using CarRentals.Domain;
using CarRentals.Models.DAL;
using CarRentals.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace CarRentals.Service.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {

        public void CreateCustomer(Customer customer)
        {
            var context = new CarRentalsContext();
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void DeleteCustomer(Customer customer)
        {
            var context = new CarRentalsContext();
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public void DeleteCustomerById(int customerId)
        {
            var context = new CarRentalsContext();
            var customer = context.Customers.Where(c => c.ID == customerId).FirstOrDefault();
            context.Customers.Remove(customer);
            context.SaveChanges();

        }

        public Customer GetCustomerById(int customerId)
        {
            var context = new CarRentalsContext();
            return context.Customers.FirstOrDefault(c => c.ID == customerId);
        }

        //public void UpdateCustomer(Customer customer)
        //{
        //    var context = new CarRentalsContext();
        //    context.Customers
           
        //}
    }
}





