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
    class DemeritPointsCalculatorTests
    {
        [Test]
        [TestCase(80,3)]
        [TestCase(0,0)]
        [TestCase(65,0)]
        [TestCase(68,0)]
        [TestCase(38,0)]
        public void DemeritPointsCalculator_over5Km_return1PointPer5Km(int km , int expectetResult)
        {
            DemeritPointsCalculator demeritPointsCalculator = new DemeritPointsCalculator();
            var result = demeritPointsCalculator.CalculateDemeritPoints(km);
            Assert.That(result, Is.EqualTo(expectetResult));
        }
        [Test]
        [TestCase(-3)]
        [TestCase(308)]
        public void DemeritPointsCalculator (int km)
        {
            DemeritPointsCalculator demeritPointsCalculator = new DemeritPointsCalculator();
            Assert.That(() => demeritPointsCalculator.CalculateDemeritPoints(km),
                Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
