using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if(obj is Point p)
                return Math.Abs(X - p.X) < Geometry.Epsilon &&
                    Math.Abs(Y - p.Y) < Geometry.Epsilon;

            return false;
        }

        public override string ToString() => $"Точка ({X}; {Y})";

        public override int GetHashCode()
        {
            return Math.Round(X, Geometry.Accuracy).GetHashCode() ^ 
                Math.Round(Y, Geometry.Accuracy).GetHashCode();
        }

    }
}
