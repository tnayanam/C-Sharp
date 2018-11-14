using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnFirstArguments(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b); // same code
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZer_ReturnOddNumberUptoLimit()
        {
            var res = _math.GetOddNumbers(5);
            // Type 1.
            Assert.That(res, Is.Not.Empty);

            // Type 2.
            Assert.That(res.Count(), Is.EqualTo(3));

            // Type 3.
            Assert.That(res, Does.Contain(1));
            Assert.That(res, Does.Contain(3));
            Assert.That(res, Does.Contain(5));

            // Type 4. same as Type 3.
            Assert.That(res, Is.EquivalentTo(new[] {1,3,5}));

            // Type 5.
            Assert.That(res, Is.Ordered);

            // Type 6.
            Assert.That(res, Is.Unique);
        }
    }
}

// problem with above approach is that we have math class instantiated too man y times in each of the mehtods. so we need to fix it.
// Problem is all the code above looks same so we need to use just one function and be able to do all threee max function output.
