using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.Tests
{
    [TestFixture]
    public class Tests
    {
        private Math _math;
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCall_SumOfArguments()
        {
            var math = new Math();
            var result = math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {

            var result = _math.Max(3, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {

            var result = _math.Max(2, 3);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void Max_ArgumentsIsEqule_ReturnArgument()
        {

            var result = _math.Max(3, 3);
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnGreater(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(result));

        }

    }
}