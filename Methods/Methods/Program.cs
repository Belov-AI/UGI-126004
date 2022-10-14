using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("" + x + "^2 = " + Square(x));

            Console.WriteLine("Введите действительное число");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("" + y + "^2 = " + Square(y));

            var program = new Program();
            y = program.Cube(2.7);
            Console.WriteLine(y);

            Console.ReadKey();       
        }

        /// <summary>
        /// Возводит целое число в квадрат
        /// </summary>
        /// <param name="x">Целое число, которое нужно возвести в квадрат</param>
        /// <returns></returns>
        static int Square(int x)
        {
            return x * x;
        }

        /// <summary>
        /// Возводит действительное число в квадрат
        /// </summary>
        /// <param name="x">Действительное число, которое нужно возвести в квадрат</param>
        /// <returns></returns>
        static double Square(double x)
        {
            return Math.Pow(x, 2);
        }

        double Cube(double x)
        {
            return x * x * x;
        }
    }
}
