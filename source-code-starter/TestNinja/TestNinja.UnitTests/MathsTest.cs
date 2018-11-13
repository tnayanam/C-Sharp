﻿using System;
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
        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {
            var math = new Math();
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentGreater_ReturnFirstArguments()
        {
            var math = new Math();
            var result = math.Max(2,1);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentGreater_ReturnSecondArguments()
        {
            var math = new Math();
            var result = math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsEqual_ReturnSameArguments()
        {
            var math = new Math();
            var result = math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}

// problem with above approach is that we have math class instantiated too man y times in each of the mehtods. so we need to fix it.
