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
        [Test]
        public void Dummy_ThrowsAnExceptionIfAttackedWhenIsDead_ReturnFalse()
        {
            Dummy dummy = new Dummy(0, 0);
            Assert.That(() => dummy.TakeAttack(5), Throws.InvalidOperationException);
        }
        [Test]
        public void Dummy_CanGiveExpiriansWhenIsDead_ReturnTrue()
        {
            Dummy dummy = new Dummy(0, 2);
            Assert.That(() => dummy.GiveExperience(), Is.EqualTo(2));
        }
        [Test]
        public void Dummy_CanGiveExpiriansWhenIsAlive_ReturnFolse()
        {
            Dummy dummy = new Dummy(2, 2);
            Assert.That(() => dummy.GiveExperience(), Throws.InvalidOperationException);
        } 
    }
}