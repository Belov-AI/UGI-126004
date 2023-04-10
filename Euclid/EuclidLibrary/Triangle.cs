using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public class Triangle : Figure, ICloneable
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Segment AB { get => new Segment(A, B); }
        public Segment AC { get => new Segment(A, C); }
        public Segment BC { get => new Segment(B, C); }

        public double Area 
        {
            get
            {
                var a = AB.Length;
                var b = AC.Length;
                var c = BC.Length;
                var p = (a + b + c) / 2;

                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

        public object Clone()
        {
            return new Triangle(
                A.Clone() as Point, 
                B.Clone() as Point, 
                C.Clone() as Point
                );
        }

        public override IEnumerator<Point> GetEnumerator()
        {
            yield return A;
            yield return B; 
            yield return C;
        }
    }
}
