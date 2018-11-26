using System;
using System.Collections.Generic;
using System.Linq;

namespace TestNinja.Mocking
{
    public static class BookingHelper
    {
        public static string OverlappingBookingsExist(Booking booking, IBookingRepository repository)
        {
            if (booking.Status == "Cancelled")
                return string.Empty;

            var bookings = repository.GetActiveBookings(booking.Id);

            var overlappingBooking =
                bookings.FirstOrDefault(
                    b =>
                        booking.ArrivalDate >= b.ArrivalDate
                        && booking.ArrivalDate < b.DepartureDate
                        || booking.DepartureDate > b.ArrivalDate
                        && booking.DepartureDate <= b.DepartureDate);

            return overlappingBooking == null ? string.Empty : overlappingBooking.Reference;
        }
    }

    public class UnitOfWork : IUnitOfWork
    {
        public IQueryable<T> Query<T>()
        {
            return new List<T>().AsQueryable();
        }
    }

    public class Booking
    {
        public string Status { get; set; }
        public int Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Reference { get; set; }
    }
}

/*
 * Now we are Learning Unit testing of something which has External Dependency
 * Generally we have a object which talks to external resource we need to decouple it
 * 3 Steps needs to be followed.
 * 1. Separate actual code with Whatever code that talks to an external resource put that in a different separate class. (++)
 * 2. Extract an interface from that class
 * 3. Now create a test class same as above (++) ; fake class
 * 4. Now the actual code which is currently talking to (++) will now talk to Interface.
 *
 * Old Main Code -> DB
 * MainCode -> Code that talks directly to DB -> DB
 * Main Code -> Interface -> code that talks direclty to DB -> DB
 * Change main code now to use Interface instead of "code that talks to DB"
 * Main Code -> Interface -> Code that talks to DB    -> DB
 *                        -> Fake code that talks to DB  -> Fake DB talk
 * Main code should not have any new operator because adding a new means that class is tightly coupled with that code which talks to DB
 * public void MyMethod()
 * {
 *      var reader = new FileReader();   // Get rid of this line.
 *      reader.Read();
 * }
 *
 * New Code
 * public void MyMethod(IFileReader reader) // so its dfependency are being supplied from outside. so is dependency injection
 * {
 *      reader.Read();
 * }
 * 
 */
