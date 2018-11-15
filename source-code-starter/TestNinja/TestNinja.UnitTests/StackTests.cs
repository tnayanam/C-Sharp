using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Push_ArgsIsNull_ArgsNullException()
        {
            var stack = new Stack<string>();
            Assert.That(()=>stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ValidArg_AddtheObjectToTheStack()
        {
            var stack = new Stack<string>();
            stack.Push("a");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Count_EMptyStack_RetirnZero()
        {
            var stack = new Stack<string>();
            Assert.That(stack.Count,Is.EqualTo(0));
        }


    }
}
