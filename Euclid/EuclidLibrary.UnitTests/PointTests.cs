namespace EuclidLibrary.UnitTests
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void Constructor_Values_CorrectAssigment()
        {
            var p = new Point(1, 2);
            Assert.That(p.X, Is.EqualTo(1));
            Assert.That(p.Y, Is.EqualTo(2));
        }

        [TestCase(1, 2, 1, 2, true)]
        [TestCase(1, 2, 2, 2, false)]
        [TestCase(1, 2, 1, 3, false)]
        [TestCase(1, 2, -1, 5, false)]
        public void Equals_ToPoint_Result(
            double x1, double y1, 
            double x2, double y2, 
            bool result)
        {
            var a = new Point(x1, y1);
            var b = new Point(x2, y2);

            Assert.That(a.Equals(b), Is.EqualTo(result));
        }

        [Test]
        public void Equals_ToObject_False()
        {
            var a = new Point(1, 2);
            var b = new object();

            Assert.That(a.Equals(b), Is.False);
        }

        [Test]
        public  void ToStringTest()
        {
            var a = new Point(-1, 2.5);

            Assert.That(a.ToString(), Is.EqualTo("Точка (-1; 2,5)"));
        }

        [TestCase(1, 2, 1, 2, true)]
        [TestCase(1, 2, 2, 2, false)]
        [TestCase(1, 2, 1, 3, false)]
        [TestCase(1, 2, -1, 5, false)]
        public void GetHashCode_TwoPoints_Result(
            double x1, double y1,
            double x2, double y2,
            bool result)
        {
            var a = new Point(x1, y1);
            var b = new Point(x2, y2);

            Assert.That(a.GetHashCode() == b.GetHashCode(), Is.EqualTo(result));
        }

        [Test]
        public void CloneTest()
        {
            Point a = new Point(1, 2);
            Point b = a.Clone() as Point;

            Assert.That(b, Is.Not.SameAs(a));
            Assert.That(a.Equals(b), Is.True);

            b.X = -1;
            b.Y = 0;
            Assert.That(a.Equals(b), Is.False);
        }
    }
}