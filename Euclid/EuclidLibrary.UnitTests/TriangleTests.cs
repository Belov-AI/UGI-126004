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
    }
}
