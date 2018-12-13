using CarRentals.Domain;
using CarRentals.Services.Interface;
using Newtonsoft.Json;
using System;
using CarRentals.Repository.Implementation;


namespace CarRentals.Services.Implementation
{
    public class CustomerRestService : ICustomerRestService
    {
        CustomerRepository customerRepo = new CustomerRepository();

        public void AddCustomer(Customer customer)
        {
            customerRepo.CreateCustomer(customer);
        }

        public string GetAllCustomer()
        {
            var customers = customerRepo.GetAllCustomer();
            return JsonConvert.SerializeObject(customers);
        }

        public string GetCustomerById(string id)
        {
            
            return JsonConvert.SerializeObject(customerRepo.GetCustomerById(Convert.ToInt32(id)));
        }
    }
}
