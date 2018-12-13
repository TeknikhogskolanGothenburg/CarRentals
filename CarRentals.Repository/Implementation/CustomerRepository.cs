using CarRentals.Domain;
using CarRentals.Models.DAL;
using CarRentals.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CarRentals.Repository.Implementation
{
    public class CustomerRepository : ICustomerRepository
    {

        public void CreateCustomer(Customer customer)
        {
            using (var context = new CarRentalsContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            using (var context = new CarRentalsContext())
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }

        public void DeleteCustomerById(int customerId)
        {
            using (var context = new CarRentalsContext())
            {
                var customer = context.Customers.Where(c => c.ID == customerId).FirstOrDefault();
                context.Customers.Remove(customer);
                context.SaveChanges();
            }

        }

        public List<Customer> GetAllCustomer()
        {
            using (var context = new CarRentalsContext())
            {
                return context.Customers.ToList();
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            using (var context = new CarRentalsContext())
            {
                return context.Customers.FirstOrDefault(c => c.ID == customerId);
            }
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            using (var context = new CarRentalsContext())
            {
                var existingCustomer = context.Customers.Where(x => x.ID == id).Select(x => x).FirstOrDefault();
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                context.SaveChanges();

            }
        }
    }
}
