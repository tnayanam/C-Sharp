using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_RetirnError()
        {
            var svc = new VideoService(new FakeFileReader());
            var result = svc.ReadVideoTitle(); // this is how we are injecting the dependencies.

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
