using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary.UnitTests
{
    [TestFixture]
    public class GeometryTests
    {
        [TestCase(-1, 1, true)]
        [TestCase(1, 2, true)]
        [TestCase(-3, 0, true)]
        [TestCase(3, 3, false)]
        [TestCase(-5, -1, false)]
        [TestCase(-1, 2, false)]
        [TestCase(1, -1, false)]
        public void IsPointInsideSegmentTest(double x, double y, bool result)
        {
            var s = new Segment(new Point(1, 2), new Point(-3, 0));
            var p = new Point(x, y);

            Assert.That(Geometry.IsPointInsideSegment(p, s), Is.EqualTo(result));
        }

        [Test]
        public void CreateSegment_DifferentPoints_Segment()
        {
            var a = new Point(1, 2);
            var b = new Point(3, 4);

            var s = Geometry.CreateSegment(a, b);

            Assert.That(s.A.X, Is.EqualTo(1));
            Assert.That(s.A.Y, Is.EqualTo(2));
            Assert.That(s.B.X, Is.EqualTo(3));
            Assert.That(s.B.Y, Is.EqualTo(4));
        }

        [Test]
        public void CreateSegment_EqualPoints_AgrumentException()
        {
            var a = new Point(1, 2);
            var b = new Point(1, 2);

            Assert.That(() => Geometry.CreateSegment(a, b), 
                Throws.ArgumentException);
        }
    }
}
