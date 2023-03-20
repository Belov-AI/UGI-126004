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
        static Point a;
        static Point b;

        [SetUp]
        public void Setup()
        {
            a = new Point(1, 2);
            b = new Point(-3, 0);
            s = new Segment(a, b);      
        }


        [Test]
        public void ConstructorTest()
        {
            Assert.That(s.A.Equals(a), Is.True);
            Assert.That(s.B.Equals(b), Is.True);
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
