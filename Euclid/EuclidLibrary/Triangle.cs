using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Segment AB { get => new Segment(A, B); }
        public Segment AC { get => new Segment(A, C); }
        public Segment BC { get => new Segment(B, C); }

        public Triangle(Point a, Point b, Point c)        {
            A = a;
            B = b;
            C = c;
        }
    }
}
