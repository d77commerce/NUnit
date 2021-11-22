using FightingArena;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase ("Stoiko",50,60)]
        public void ConstructorShouldSet(string name, 
                int dameage,
                int healt)
        {
            Warrior warrior = new Warrior(name ,dameage,healt);
                
            Assert.Pass();
        }
    }
}