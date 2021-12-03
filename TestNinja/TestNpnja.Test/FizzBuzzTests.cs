using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
  public  class FizzBuzzTests
    {
        [Test]
        public void GeetOutput_InputDivisible3Or5_ReturnFizzBuzz()
        {

            var result = FizzBuzz.GetOutput(150);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }
        [Test]
        public void GeetOutput_InputDivisible3_ReturnFizzBuzz()
        {

            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void GeetOutput_InputDivisible5_ReturnFizzBuzz()
        {

            var result = FizzBuzz.GetOutput(50);
            Assert.That(result, Is.EqualTo("Buzz"));
        }
        [Test]
        public void GeetOutput_InputNotDivisible3Or5_ReturnInput()
        {

            var result = FizzBuzz.GetOutput(1);
            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
