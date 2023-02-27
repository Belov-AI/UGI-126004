namespace EuclidLibrary.UnitTests
{
    [TestFixture]
    public class PointTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Constructor_Values_CorrectAssigment()
        {
            var p = new Point(1, 2);
            Assert.That(p.X, Is.EqualTo(1));
            Assert.That(p.Y, Is.EqualTo(2));
        }
    }
}