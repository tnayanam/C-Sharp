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
    class EmployeeControllerTests
    {
        private Mock<IEmployeeStorage> _storage;
        private EmployeeController _controller;

        [SetUp]
        public void SetUp()
        {
            _storage = new Mock<IEmployeeStorage>();
            _controller = new EmployeeController(_storage.Object);
        }
        [Test]
        public void DeleteEmployee() // in this test we are just checking whethere the right call has been made to employeestorage wit the right parameters
        {
            _controller.DeleteEmployee(2);

            _storage.Verify(s=>s.DeleteEmployee(2));
        }
    }
}
