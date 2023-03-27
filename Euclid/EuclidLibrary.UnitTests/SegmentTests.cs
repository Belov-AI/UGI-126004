using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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

        [TestCase(1, 2, -1, 3, 1, 2, -1, 3, true)]
        [TestCase(1, 2, -1, 3, -1, 3, 1, 2, true)]
        [TestCase(1, 2, -1, 3, 1, 3, -2, 4, false)]
        public void Equals_ToSegment_Result(
            double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4,
            bool result)
        {
            var s1 = new Segment(new Point(x1, y1), new Point(x2, y2));
            var s2 = new Segment(new Point(x3, y3), new Point(x4, y4));

            Assert.That(s1.Equals(s2), Is.EqualTo(result));
        }
    }
}
