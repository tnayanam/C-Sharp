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
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader; 
        private VideoService _svc; 
        [SetUp]
        public void SetUp()
        {
           _fileReader = new Mock<IFileReader>();
            _svc = new VideoService(_fileReader.Object);
        }
        [Test]
        public void ReadVideoTitle_EmptyFile_RetirnError()
        {
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");

            var result = _svc.ReadVideoTitle(); // this is how we are injecting the dependencies.

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }
}
