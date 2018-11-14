using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathsTest
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [Ignore("Because I wanted to!")]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(2,1,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnFirstArguments(int a, int b, int expectedResult)
        {
            var result = _math.Max(a,b); // same code
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}

// problem with above approach is that we have math class instantiated too man y times in each of the mehtods. so we need to fix it.
// Problem is all the code above looks same so we need to use just one function and be able to do all threee max function output.
