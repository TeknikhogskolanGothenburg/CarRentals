using CarRentals.Domain;
using CarRentals.Models.DAL;
using CarRentals.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentals.Service.Implementation
{
    public class BookingRepository : IBookingRepository
    {
        public void CreateBooking(Booking booking)
        {
            var context = new CarRentalsContext();
            context.Bookings.Add(booking);
            context.SaveChanges();
        }

        public void DeleteBooking(Booking booking)
        {
            var context = new CarRentalsContext();
            context.Bookings.Remove(booking);
            context.SaveChanges();
        }

        public void DeleteBookingById(int bookingId)
        {
            var context = new CarRentalsContext();
            var booking = context.Bookings.Where(b => b.ID == bookingId).FirstOrDefault();
            context.Bookings.Remove(booking);
            context.SaveChanges();
        }
    
        public void DropOfCar(int bookingId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAvalibleCars(DateTime dateFrom, DateTime dateTo)
        {
            throw new NotImplementedException();
        }

        public Booking GetBookingById(int bookingId)
        {
            var context = new CarRentalsContext();
            return context.Bookings.FirstOrDefault(b => b.ID == bookingId);
        }


    }
}


