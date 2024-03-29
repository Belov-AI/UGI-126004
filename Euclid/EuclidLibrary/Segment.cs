﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public class Segment : Figure, ICloneable
    {
        public Point A;
        public Point B;

        public double Length
        {
            get
            {
                var dx = A.X - B.X;
                var dy = A.Y - B.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }


        public Segment(Point a, Point b)
        {
            A = a;
            B = b;
        }

        public bool IsPointInside(Point p)
        {
            if(Math.Abs((p.X - A.X) * (B.Y - p.Y) - (p.Y - A.Y) * (B.X - p.X)) < Geometry.Epsilon &&
                (p.X - A.X) * (B.X - p.X) + (p.Y - A.Y) * (B.Y - p.Y) > -Geometry.Epsilon)
                return true;

            return false;
        }

        public override bool Equals(object obj)
        {
            if(obj is Segment s)
                return A.Equals(s.A) && B.Equals(s.B) || A.Equals(s.B) && B.Equals(s.A);

            return false;
        }

        public object Clone()
        {
            return new Segment(A.Clone() as Point, B.Clone() as Point);
        }

        public override IEnumerator<Point> GetEnumerator()
        {
            return new SegmentEnumerator(this);
        }

        //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
