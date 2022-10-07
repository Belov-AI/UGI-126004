using System;

namespace SinCos
{
    class Program
    {
        static void Main()
        {
            double angle = 15 * Math.PI / 180;
            Console.WriteLine("sin(15°) = " + Math.Round(Math.Sin(angle), 3));
            Console.WriteLine("cos(15°) = " + Math.Round(Math.Cos(angle), 3));

            angle = 37 * Math.PI / 180;
            Console.WriteLine("sin(37°) = " + Math.Round(Math.Sin(angle), 3));
            Console.WriteLine("cos(37°) = " + Math.Round(Math.Cos(angle), 3));

            angle = 113 * Math.PI / 180;
            Console.WriteLine("sin(113°) = " + Math.Round(Math.Sin(angle), 3));
            Console.WriteLine("cos(113°) = " + Math.Round(Math.Cos(angle), 3));

            Console.ReadKey();
        }
    }
}
