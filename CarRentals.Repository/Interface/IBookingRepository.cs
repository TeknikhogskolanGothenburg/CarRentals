using CarRentals.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentals.Repository.Interface
{
    public interface IBookingRepository
    {
        void CreateBooking(Booking booking);
        void DeleteBooking(Booking booking);
        Booking GetBookingById(int bookingId);
        void DeleteBookingById(int bookingId);
        List<Booking> GetAllBookings();
    }
}





