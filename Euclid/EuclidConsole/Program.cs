using EuclidLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuclidConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point { X = 1, Y = 2 };
            Console.WriteLine($"Точка A({a.X}; {a.Y})");

            var b = new Point { X = -3, Y = 0 };
            Console.WriteLine($"Точка В({b.X}; {b.Y})");

            Segment s = new Segment { A = a, B = b };
            Console.WriteLine($"Отрезок с концами в точках ({s.A.X}; {s.A.Y}) и ({s.B.X}; {s.B.Y})");

            Console.ReadKey();
        }

    }
}
