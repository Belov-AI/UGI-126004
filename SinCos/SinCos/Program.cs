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
            
            PrintFunctionValue("sin", angleInDegrees, Math.Sin(angleInRadians));
            PrintFunctionValue("cos", angleInDegrees, Math.Cos(angleInRadians));
        }

        private static double DegreesToRadians(double angleInDegrees)
        {
            return angleInDegrees * Math.PI / 180;
        }

        static void PrintFunctionValue(string name, double argument,double val)
        {
            Console.WriteLine($"{name}({argument}°) = {val:F3}");
        }
    }
}
