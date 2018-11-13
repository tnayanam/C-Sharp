using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests // Notice this convention. class tat we are trying to test followed by "tests"
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue() // convention methodname_scenariobeingtested_expectedoutcome
        {
            // Arrange
            var reservation = new Reservation();
            // Act
           var result =  reservation.CanBeCancelledBy(new User {IsAdmin = true});
            //Assert
            Assert.IsTrue(result);
        }
    }
}
