using System.Security.Cryptography;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;   
        
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [TearDown]
        public void TearDown()
        {
            _math = null;
        }

        [TestCase(1, 2, 3)]
        public void Add_WhenCalled_ReturnsTheSumOfArguments(int a, int b, int result)
        {
            var sum = _math.Add(a, b);
            Assert.That(sum, Is.EqualTo(result));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            var result = _math.Max(2, 1);
            Assert.That(result, Is.EqualTo(2));
        }
        
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            var result = _math.Max(1, 2);
            Assert.That(result, Is.EqualTo(2));
        }
        
        [Test]
        public void Max_BothArgumentsEqual_ReturnsTheSameArguments()
        {
            var result = _math.Max(1, 1);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}