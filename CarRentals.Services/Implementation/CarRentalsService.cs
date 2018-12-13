using System;
using System.Collections.Generic;
using System.ServiceModel;
using CarRentals.Domain;
using CarRentals.Repository.Implementation;
using CarRentals.Services.CustomerRequestMsg;


namespace CarRentals.Services.Implementation
{

    public class CarRentalsService : IBookingService, ICarService, ICustomerService
    {
        CustomerRepository customerRepo = new CustomerRepository();
        BookingRepository bookingRepo = new BookingRepository();
        CarRepository carRepo = new CarRepository();

        #region Car
        public List<Car> GetAllCars()
        {
            return carRepo.GetAllCars();
        }


        public void AddCar(Car car)
        {
            if (String.IsNullOrEmpty(car.Brand) || String.IsNullOrEmpty(car.CarModel)
              || String.IsNullOrEmpty(car.RegistrationNo) || car.ManufacturingYear ==0) 
            {
                throw new FaultException("You must fill in all fields above");
            }
            carRepo.CreateCar(car);
        }

        public Car GetCarById(int id)
        {
            var car = carRepo.GetCarById(id);
            if(car == null)
            {
                throw new FaultException ("Car with id: " + id + " was not found");
            }
            return carRepo.GetCarById(id);
        }

        public void DeleteCar(Car car)
        {
            carRepo.DeleteCar(car);
        }

        public void DeleteCarById(int id)
        {

            carRepo.DeleteCarById(id);

        }

        public List<Car> GetAvalibleCars(DateTime dateFrom, DateTime dateTo)
        {
            return carRepo.GetAvalibleCars(dateFrom, dateTo);

        }
        #endregion

        #region Customer
        public void AddCustomer(CustomerRequestMessage customerRequestMessage)
        {
            if(customerRequestMessage.Key == System.Configuration.ConfigurationManager.AppSettings["ApiKeyLocalHost"])
            {
               if (String.IsNullOrEmpty(customerRequestMessage.Customer.FirstName) || String.IsNullOrEmpty(customerRequestMessage.Customer.LastName) ||
               String.IsNullOrEmpty(customerRequestMessage.Customer.PhoneNumber) || String.IsNullOrEmpty(customerRequestMessage.Customer.Email))

                {
                    throw new FaultException("You must fill in all fields above");
                }
                customerRepo.CreateCustomer(customerRequestMessage.Customer);

            }
            else
            {
                throw new FaultException("You have enter wrong key");
            }
            
        }

        public Customer GetCustomerByID(int Id)
        {

                var customer = customerRepo.GetCustomerById(Id);

                if (customer == null)
                {
                    throw new FaultException("Customer with id:" + Id + " was not found");
                }
                return customer;
        }

        public void DeleteCustomer(Customer customer)
        {

            customerRepo.DeleteCustomer(customer);
        }

        public void DeleteCustomerbyId(int id)
        {
            customerRepo.DeleteCustomerById(id);
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            customerRepo.UpdateCustomer(id, customer);
        }


        public List<Customer> GetAllCustomer()
        {
            return customerRepo.GetAllCustomer();
        }
        #endregion

        #region Booking
        public void AddBooking(Booking booking)
        {
            bookingRepo.CreateBooking(booking);
        }

        public List<Booking> GetAllBookings()
        {
            return bookingRepo.GetAllBookings();
        }

        public void DeleteBookingById(int id)
        {
            bookingRepo.DeleteBookingById(id); 
        }

        public Booking GetBookingById(int id)
        {
            return bookingRepo.GetBookingById(id);
        }
        #endregion
    }
}
