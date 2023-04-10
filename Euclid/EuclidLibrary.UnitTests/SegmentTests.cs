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

        [Test]
        public void CloneTest()
        {
            Segment s2 = s.Clone() as Segment;

            Assert.That(s2, Is.Not.SameAs(s));
            Assert.That(s.Equals(s2), Is.True);

            s2.A = new Point(-1, 4);
            s2.B = new Point(0, 1);
            Assert.That(s.Equals(s2), Is.False);
        }

        [Test]
        public void GetEnumeratorTest()
        {
            var points = new Point[] { a, b };
            int i = 0;

            foreach(var point in s)
                Assert.That(point, Is.SameAs(points[i++]));
        }

        [Test]
        public void RotateTest()
        {
            var center = new Point(2, 1);
            var angleInDegrees = 30;

            var p = new Point(1, 2);
            var pRotated = new Point(
                2 - Math.Sqrt(2) * Math.Cos(Math.PI / 12),
                1 + Math.Sqrt(2) * Math.Sin(Math.PI / 12)
                );

            var q = new Point(0, -1);
            var qRotated = new Point(
                2 - 2 * Math.Sqrt(2) * Math.Sin(Math.PI / 12),
                1 - 2 * Math.Sqrt(2) * Math.Cos(Math.PI / 12)
                );

            var segment = new Segment(p, q);
            var segmentRotated = new Segment(pRotated, qRotated);

            segment.Rotate(angleInDegrees, center);

            Assert.That(segment.Equals(segmentRotated), Is.True);
        }
    }
}
