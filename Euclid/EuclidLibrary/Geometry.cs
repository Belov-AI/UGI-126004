using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public static class Geometry
    {
        public static readonly int Accuracy = 8;
        public static readonly double Epsilon = Math.Pow(10,-Accuracy);
        public static Segment CreateSegment(Point a, Point b)
        {
            if (a.Equals(b))
                throw new ArgumentException("Вырожденный отрезок");

            return new Segment(a, b);
        }

        public static bool IsPointInsideSegment(Point p, Segment s) => s.IsPointInside(p);
    }
}
