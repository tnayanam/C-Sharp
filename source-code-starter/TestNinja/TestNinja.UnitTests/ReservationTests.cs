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
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() // convention methodname_scenariobeingtested_expectedoutcome
        {
            // Arrange
            var reservation = new Reservation();
            // Act
           var result =  reservation.CanBeCancelledBy(new User {IsAdmin = true});
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_SameUserCancelling_ReturnsTrue() // convention methodname_scenariobeingtested_expectedoutcome
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation{MadeBy = user};
            // Act
            var result = reservation.CanBeCancelledBy(user);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnsFalse() // convention methodname_scenariobeingtested_expectedoutcome
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            // Act
            var result = reservation.CanBeCancelledBy(new User ());
            //Assert
            Assert.IsFalse(result);
        }
    }
}


// to run the test click on test in VS top menu and then click on run and then "all tests"