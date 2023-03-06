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
        }
    }
}
