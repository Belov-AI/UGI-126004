using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public abstract class Figure : IEnumerable<Point>
    {
        public abstract IEnumerator<Point> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void Rotate(double angleInDegrees, Point center)
        { 
            foreach(var point in this)
                point.Rotate(angleInDegrees, center);
        }
    }
}
