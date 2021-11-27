using NUnit.Framework;


namespace Database.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Add_AddElementANextFreeCell_ReturnTrue()
        {
            Database database = new Database();
            database.Add(1);
            Assert.That(database.Count, Is.EqualTo(1));
        }
        [Test]
        public void Add_MoreOf16Elements_Returnfalse()
        {
            Database database = new Database();

            for (int i = 0; i < 16; i++)
            {
                database.Add(3);
            }
            Assert.That(() => database.Add(3), Throws.InvalidOperationException);
        }
        [Test]
        public void Remuve_RemuveElementANextFreeCell_ReturnTrue()
        {
            Database database = new Database();
            database.Add(1);
            database.Add(2);
            database.Remove();
            var result = database.Count;
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Remuve_RemuveInEmptyDatabase_ReturnFalse()
        {
            Database database = new Database();

            Assert.That(() => database.Remove(), Throws.InvalidOperationException);
        }
        [Test]
        public void Fetch_CopyArray_ReturnNewArrey()
        {
            Database database = new Database();
            database.Add(2);
            database.Add(2);

            Assert.That(database.Fetch(), Is.Not.Empty);
        }
    }
}