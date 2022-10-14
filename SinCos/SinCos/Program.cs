using System;

namespace SinCos
{
    class Program
    {
        static void Main()
        {
            PrintSinusCosinus(15);
            PrintSinusCosinus(37);
            PrintSinusCosinus(113);
            
            Console.ReadKey();
        }

        static void PrintSinusCosinus(double angleInDegrees)
        {
            double angleInRadians = DegreesToRadians(angleInDegrees);
            Console.WriteLine("sin(" + angleInDegrees + "°) = " + Math.Round(Math.Sin(angleInRadians), 3));
            Console.WriteLine("cos(" + angleInDegrees + "°) = " + Math.Round(Math.Cos(angleInRadians), 3));
        }

        private static double DegreesToRadians(double angleInDegrees)
        {
            return angleInDegrees * Math.PI / 180;
        }
    }
}
