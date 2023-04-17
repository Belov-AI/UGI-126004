using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;

namespace Sequences
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s = new Sequence();

            Console.WriteLine("Числа Фибоначчи");
            PrintSequence(s.Fibonacci());
            Console.WriteLine();

            Console.WriteLine("Факториалы");
            PrintSequence(s.Factorial());

            Console.ReadKey();
        }

        static void PrintSequence(IEnumerable<BigInteger> sequence)
        {
            foreach(var item in sequence)
            {
                Console.Write($"{item} ");
                Thread.Sleep(300);

                if(Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    // Enter - пауза
                    if(key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                        while (true)
                        {
                            if (Console.KeyAvailable)
                            {
                                key = Console.ReadKey();

                                if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.Escape)
                                    break;
                            }
                        }
                    }

                    // Esc - окончание печати
                    if (key.Key == ConsoleKey.Escape)
                        break;
                }
            }
        }

    }
}
