using CarRentals.Domain;
using CarRentals.Models.DAL;
using CarRentals.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CarRentals.Repository.Implementation
{
    public class BookingRepository : IBookingRepository
    {
        public void CreateBooking(Booking booking)
        {
            using(var context = new CarRentalsContext())
            {
                context.Bookings.Add(booking);
                context.SaveChanges();
            }
        }

        public void DeleteBooking(Booking booking)
        {
            using(var context = new CarRentalsContext())
            {
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }
        }

        public void DeleteBookingById(int bookingId)
        {
            using(var context = new CarRentalsContext())
            {
                var booking = context.Bookings.Where(b => b.ID == bookingId).FirstOrDefault();
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }

        }
    
        public List<Booking> GetAllBookings()
        {
            using(var context = new CarRentalsContext())
            {
                return context.Bookings.ToList();
            } 
        }

        public Booking GetBookingById(int bookingId)
        {
            using(var context = new CarRentalsContext())
            {
                return context.Bookings.FirstOrDefault(b => b.ID == bookingId);
            }
        }

    }
}


