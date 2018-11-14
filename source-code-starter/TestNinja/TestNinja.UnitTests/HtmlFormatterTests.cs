﻿using System;
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
   public  class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            var result = formatter.FormatAsBold("abc");

            // specific
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));

            // More general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.Contain("abc"));
            Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}
