using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Point : IDrawable
    {
        public const double Epsilon = 1e-8;

        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Color Outline { get; set; }

        public void Draw()
        {
            Console.WriteLine("Рисуем точку");
        }

        public override bool Equals(object obj)
        {
            if(obj is Point p)
                return Math.Abs(X - p.X) < Epsilon &&
                    Math.Abs(Y - p.Y) < Epsilon;

            return false;
        }
    }
}
