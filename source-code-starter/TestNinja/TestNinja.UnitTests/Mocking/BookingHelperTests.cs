using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class BookingHelperTests_OverlappingBookingsExistTests  // ALWAYS REMEMBER YOU NEED TO MOCK THE EXTERNAL DEPENDENCY
    {
        [Test]
        public void BookingStartsAndFinishesBeforeAnExistingMeeting_ReturnEmptyString()
        {
            var repository = new Mock<IBookingRepository>();
            repository.Setup(r => r.GetActiveBookings(1)).Returns(new List<Booking>
            {
                new Booking()
                {
                    Id =2,
                    Reference = "a",
                    ArrivalDate = ArriveOn(2017,1,15),
                    DepartureDate = DepartOn(2017,1,20),
                }
            }.AsQueryable());

            var result = BookingHelper.OverlappingBookingsExist(new Booking()
            {
                Id = 1,
                ArrivalDate = ArriveOn(2017,1,10),
                DepartureDate = DepartOn(2017,1,14),
            }, repository.Object);

            Assert.That(result,Is.Empty);
        }

        private DateTime ArriveOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 14,0,0);
        }

        private DateTime DepartOn(int year, int month, int day)
        {
            return new DateTime(year, month, day, 10, 0, 0);
        }
    }
}
