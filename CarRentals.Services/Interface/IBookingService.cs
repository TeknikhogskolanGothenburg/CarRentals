using CarRentals.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarRentals.Services
{
    
    [ServiceContract]
    public interface IBookingService
    {
        [OperationContract]
        void AddBooking(Booking booking);

        [OperationContract]
        List<Booking> GetAllBookings();

        [OperationContract]
        void DeleteBookingById(int id);

        [OperationContract]
        Booking GetBookingById(int id);
    }

}
  
