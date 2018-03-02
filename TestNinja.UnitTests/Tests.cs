using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        [Test]
        [TestCase(1, 2, 3)]
        public void Add_WhenCalled_ReturnsTheSumOfArguments(int a, int b, int result)
        {
            var math = new Fundamentals.Math();
            var sum = math.Add(a, b);
            Assert.That(sum, Is.EqualTo(result));
        }
    }
}