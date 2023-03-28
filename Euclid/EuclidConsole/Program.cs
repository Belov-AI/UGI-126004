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
            Point a = new Point(1, 2);
            Console.WriteLine(a);
            //Console.WriteLine($"Точка A({a.X}; {a.Y})");

            var b = new Point(-3, 0);
            Console.WriteLine(b);
            //Console.WriteLine($"Точка В({b.X}; {b.Y})");

            Segment s = new Segment(a, b);
            PrintSegmentInfo(s);
            Console.WriteLine($"Длина отрезка равна {s.Length}");

            try
            {
                var anotherSegment = Geometry.CreateSegment(new Point(0, 0), new Point(1, 1));
                PrintSegmentInfo(anotherSegment);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                var anotherSegment = Geometry.CreateSegment(new Point(1, 1), new Point(1, 1));
                PrintSegmentInfo(anotherSegment);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            s = new Segment(new Point(1, 1), new Point(3, 2));
            Console.WriteLine(s.IsPointInside(new Point(2, 1.5)));
            Console.WriteLine(s.IsPointInside(new Point(1, 1)));
            Console.WriteLine(s.IsPointInside(new Point(3, 2)));
            Console.WriteLine(s.IsPointInside(new Point(-1, 0)));
            Console.WriteLine(s.IsPointInside(new Point(2, 2)));
            Console.WriteLine(s.IsPointInside(new Point(2, 0)));

            Console.ReadKey();
        }

        static void PrintSegmentInfo(Segment s)
        {
            Console.WriteLine($"Отрезок с концами в точках ({s.A.X}; {s.A.Y}) и ({s.B.X}; {s.B.Y})");
        }
    }
}
