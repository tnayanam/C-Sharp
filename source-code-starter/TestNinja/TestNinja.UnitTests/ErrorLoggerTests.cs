using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
   public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();

            Assert.That(() => logger.Log(error),Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new ErrorLogger();
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            // here we are subscribing to the event, so that when the
            // event gets raised this method gets notified
            // we are subscribing to the event.

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
