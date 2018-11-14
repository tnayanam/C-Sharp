using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        [TestCase(6,"Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(5, "Buzz")]
        [TestCase(7, "7")]
        public void GetOutput_FizzTest_ReturnFi(int num, string output)
        {
            var res = FizzBuzz.GetOutput(num);
            Assert.That(res, Is.EqualTo(output));
        }
    }
}
