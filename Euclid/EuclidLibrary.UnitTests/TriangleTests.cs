using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary.UnitTests
{
    [TestFixture]
    public class TriangleTests
    {
        static Point a;
        static Point b;
        static Point c;
        static Triangle t;

        [SetUp]        
        public void Setup()
        {
            a = new Point(1, 2);
            b = new Point(-1, 4);
            c = new Point(2, 3);
            t = new Triangle(a, b, c);
        }


        [Test]
        public void ConstructorTest()
        {
            Assert.That(t.A.Equals(a), Is.True);
            Assert.That(t.B.Equals(b), Is.True);
            Assert.That(t.C.Equals(c), Is.True);   
        }

        [Test]
        public void SidesTest()
        {
            var a = new Point(1, 2);
            var b = new Point(-1, 3);
            var c = new Point(2, 0);

            var t = new Triangle(a, b, c);

            Assert.That(t.AB.Equals(new Segment(b, a)), Is.True);
            Assert.That(t.AB.Equals(new Segment(a, c)), Is.False);
            Assert.That(t.AC.Equals(new Segment(c, a)), Is.True);
            Assert.That(t.AC.Equals(new Segment(c, b)), Is.False);
            Assert.That(t.BC.Equals(new Segment(c, b)), Is.True);
            Assert.That(t.BC.Equals(new Segment(b, a)), Is.False);
        }

        [Test]
        public void AreaTest()
        {
            var delta = Math.Abs(t.Area - 2);

            Assert.That(delta, Is.LessThan(Geometry.Epsilon));
        }

        [Test]
        public void GetEnumerator()
        {
            var vertexes = new[] { a, b, c };
            var i = 0;

            foreach ( var vertex in vertexes )
                Assert.That(vertex, Is.SameAs(vertexes[i++]));
        }
    }
}
