using NUnit.Framework;
using System;
using System.Linq;

namespace ExtendedDatabase.Tests
{
    public class ExtendedDatabaseTests
    {
        long id = 14;
        string name = "Ivan";

       

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Add_IfThereAreAlreadyUsersWithUsername_RetunExeption()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            Person person = new Person(id,name);
            extendedDatabase.Add(person);
            Person person1 = new Person(342222, name);
            Assert.That(()=>extendedDatabase.Add(person1), Throws.InvalidOperationException);

        }
        [Test]
        public void Add_IfThereAreAlreadyUsersWithId_RetunExeption()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            Person person = new Person(id, name);
            extendedDatabase.Add(person);
            Person person1 = new Person(id, "Marshala");
            Assert.That(() => extendedDatabase.Add(person1), Throws.InvalidOperationException);

        }
        [Test]
        public void Remuve_FromDatabase()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            Person person = new Person(id, name);
            extendedDatabase.Add(person);
            Assert.That(() => extendedDatabase.Remove(), Is.True);
        }
        [Test]
        public void FindByUsername_PresentByUsername_ThrowExceotion()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            Person person = new Person(id, name);
            extendedDatabase.Add(person);
            Assert.That(() => extendedDatabase.FindByUsername("Miki"), Throws.InvalidOperationException);
        }
        [Test]
        public void FindByUsername_UsernameIsN_ThrowExceotion()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            Person person = new Person(id, name);
            extendedDatabase.Add(person);
            Assert.That(() => extendedDatabase.FindByUsername(null), Throws.ArgumentNullException);
        }

        [Test]
        public void FindById_PresentById_ThrowExceotion()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            Person person = new Person(id, name);
            extendedDatabase.Add(person);
            Assert.That(() => extendedDatabase.FindById(12345666), Throws.InvalidOperationException);
        }
        [Test]
        public void FindById_PresentByNegativeId_ThrowExceotion()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();
            Person person = new Person(id, name);
            extendedDatabase.Add(person);
            Assert.That(() => extendedDatabase.FindById(-12666), Throws.Exception);
        }
    }
}