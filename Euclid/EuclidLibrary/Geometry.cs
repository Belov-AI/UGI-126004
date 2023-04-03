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

        public static Triangle CreateTriangle(Point a, Point b, Point c) 
        { 
            var t = new Triangle(a, b, c);

            if(t.AB.Length + t.BC.Length - t.AC.Length > Epsilon &&
                t.AB.Length + t.AC.Length - t.BC.Length > Epsilon &&
                t.AC.Length + t.BC.Length -t.AB.Length > Epsilon)
                return t;

            throw new ArgumentException("Вырожденный треугольник");
        }
    }
}
