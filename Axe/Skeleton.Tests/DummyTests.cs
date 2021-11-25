using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void Dummy_LosesHealthIfAttacked_returnTrue()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(5, 20);
            axe.Attack(dummy);
            var result = dummy.Health;
            Assert.That(result, Is.EqualTo(5));

        }
    }
}