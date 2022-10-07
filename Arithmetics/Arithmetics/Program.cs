using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Введите значение а");
            a = int.Parse(Console.ReadLine());

            int x = a++ + ++a;

            Console.WriteLine("x = " + x);
            Console.WriteLine("a = " + a);

            int y;
            x = y = 0;
            Console.WriteLine(x);
            Console.WriteLine(y);

            var coeff = 9999999999999999999L;

            int z;

            checked
            {
                z = (int)coeff;
            }
            

            Console.WriteLine(z);

            var s = "42";

            z = int.Parse(s);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
