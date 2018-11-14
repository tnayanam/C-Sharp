using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            // One Way
            var result = controller.GetCustomer(0);
             Assert.That(result, Is.TypeOf<NotFound>()); // this means result should be of exact "Not Found" type

            // ANother Way
            Assert.That(result, Is.InstanceOf<NotFound>()); // this means result should be of exact "Not Found" type or any of tis derivatives

        }
    }
}
