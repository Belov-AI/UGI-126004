using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary.UnitTests
{
    [TestFixture]
    public class SegmentTests
    {
        static Segment s;

        [SetUp]
        public void Setup()
        {
            s = new Segment(new Point(1, 2), new Point(-3, 0));      
        }


        [Test]
        public void ConstructorTest()
        {
            Assert.That(s.A.X, Is.EqualTo(1));
            Assert.That(s.A.Y, Is.EqualTo(2));
            Assert.That(s.B.X, Is.EqualTo(-3));
            Assert.That(s.B.Y, Is.EqualTo(0));
        }

        [Test]
        public void LenghtTest()
        {
            var length = s.Length;

            Assert.That(length, 
                Is.EqualTo(2 * Math.Sqrt(5)).Within(Geometry.Epsilon));
        }

        [TestCase(-1, 1, true)]
        [TestCase(1, 2, true)]
        [TestCase(-3, 0, true)]
        [TestCase(3, 3, false)]
        [TestCase(-5, -1, false)]
        [TestCase(-1, 2, false)]
        [TestCase(1, -1, false)]
        public void IsPointInsideTest(double x, double y, bool result)
        {
            var p = new Point(x, y);

            Assert.That(s.IsPointInside(p), Is.EqualTo(result));
        }
    }
}
