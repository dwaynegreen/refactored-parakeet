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

        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_FirstArgumentIsGreater_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}