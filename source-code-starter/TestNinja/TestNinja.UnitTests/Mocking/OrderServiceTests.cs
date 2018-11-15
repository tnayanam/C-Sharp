using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_StoreTheOrder()
        {
            var storage = new Mock<IStorage>(); // why  we need this because our OrderService function "PlaceOrder" needs this in it.
            var service = new OrderService(storage.Object);
            var order = new Order();
            service.PlaceOrder(order);

            storage.Verify(s=>s.Store(order)); // this checks it.
        }
    }
}
// so here we are learninf teseting interaction between two objects
// in this entire flow what we are testing is the placeorder method is actually using the same argument of "store" that we are passing.
/*
 *     public int PlaceOrder(Order order)
        {

            var orderId = _storage.Store(new Order); since we are usinf a differnet objectt than what is passed out test will fail now
            
            // Some other work

            return orderId; 
        }
 * USE MOCKS ONLY WHEN REMOVING EXTENRNAL DEPENDENCIES FROM UNIT TESTS
 */
