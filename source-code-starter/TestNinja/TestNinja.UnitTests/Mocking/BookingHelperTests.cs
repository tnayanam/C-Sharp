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
                    ArrivalDate = new DateTime(2017,1,15, 14,0,0),
                    DepartureDate = new DateTime(2017,1,20,10,0,0),
                }
            }.AsQueryable());

            var result = BookingHelper.OverlappingBookingsExist(new Booking()
            {
                Id = 1,
                ArrivalDate = new DateTime(2017, 1, 10, 14, 0, 0),
                DepartureDate = new DateTime(2017, 1, 14, 10, 0, 0)
            }, repository.Object);

            Assert.That(result,Is.Empty);
        }
    }
}
