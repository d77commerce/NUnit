using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void Axe_LostDurabilityAfterAtack_ReturnTrue()
        {
            Axe axe = new Axe(20, 5);
            Dummy dummy = new Dummy(20, 20);
            axe.Attack(dummy);
            Assert.That(axe.DurabilityPoints, Is.EqualTo(4));
        }
        [Test]
        public void Axe_AtackBrokenWeapon_ReturnFalse()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);
           
            Assert.That(()=>axe.Attack(dummy), Throws.Exception);
        }
    }
}