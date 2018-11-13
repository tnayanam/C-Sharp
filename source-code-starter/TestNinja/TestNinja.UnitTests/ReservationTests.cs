using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ReservationTests // Notice this convention. class tat we are trying to test followed by "tests"
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue() // convention methodname_scenariobeingtested_expectedoutcome
        {
            // Arrange
            var reservation = new Reservation();
            // Act
           var result =  reservation.CanBeCancelledBy(new User {IsAdmin = true});
            //Assert
            Assert.IsTrue(result); // all below are same
            Assert.That(result, Is.True);
            Assert.That(result == true);
        }
        [Test]
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

        [Test]
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
// Type of tests
// MSTest
// NUnit
// XUnit
// till now we did MSTest and now we will do NUnit.
// install-package NUnit -Version 3.8.1
// make sure the project selected in package manger console is pointed to UNit test project and not the original one.
// to run Nunit inside VS we need to install another package
// Install-Package NUnit3TestAdapter -Version 3.8.0