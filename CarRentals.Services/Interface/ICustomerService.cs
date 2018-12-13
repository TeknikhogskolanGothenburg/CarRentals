using CarRentals.Domain;
using System.Collections.Generic;
using System.ServiceModel;
using CarRentals.Services.CustomerRequestMsg;

namespace CarRentals.Services
{

    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        void AddCustomer(CustomerRequestMessage customer);

        [OperationContract]
        Customer GetCustomerByID(int Id);

        [OperationContract]
        void DeleteCustomer(Customer customer);

        [OperationContract]
        void DeleteCustomerbyId(int Id);

        [OperationContract]
        void UpdateCustomer(int id, Customer customer);

        [OperationContract]
        List<Customer> GetAllCustomer();
    }
}
