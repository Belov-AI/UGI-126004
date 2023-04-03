using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidLibrary
{
    public class Point : ICloneable
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

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Rotate(double angleInDegrees, Point center)
        {
            var angleInRadians = Math.PI * angleInDegrees / 180;

            //𝑥′ = (𝑥 − 𝑎) ∙ cos 𝛼 − (𝑦 − 𝑏) ∙ sin 𝛼 + 𝑎
            var xNew = (X - center.X) * Math.Cos(angleInRadians) -
                (Y - center.Y) * Math.Sin(angleInRadians) + center.X;

            //𝑦′ = (𝑥 − 𝑎) ∙ sin 𝛼 + (𝑦 − 𝑏) ∙ cos 𝛼 + 𝑏
            var yNew = (X - center.X) * Math.Sin(angleInRadians) +
                (Y - center.Y) * Math.Cos(angleInRadians) + center.Y;
        }
    }
}
