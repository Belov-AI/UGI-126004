using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    internal class Program
    {
        static void Main()
        {
            long f = 1;
            int n = 1;

            do
            {
                f *= n;                
                Console.WriteLine($"{n}! = {f}");
                n++;
            } while (f < long.MaxValue / n);

            Console.WriteLine("Вычисление закончено.");

            Console.ReadKey();
        }
    }
}
