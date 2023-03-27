using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Line : IDrawable
    {
        //задает прямую с уравнением y = Kx + B
        public double K { get; set; }
        public double B { get; set; }

        public Color Outline { get; set; }

        public Line(double k, double b)
        {
            K = k;
            B = b;
        }

        public void Draw() => Console.WriteLine("Рисуем линию");
    }
}
