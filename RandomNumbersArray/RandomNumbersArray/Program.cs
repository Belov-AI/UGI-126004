using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            PrintIntArray(numbers);

            var rnd = new Random();

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(1000);

            PrintIntArray(numbers);

            Array.Sort(numbers);
            PrintIntArray(numbers);

            Console.ReadKey();
        }

        static void PrintIntArray(int[] array)
        {
            foreach( var number in array)
                Console.WriteLine(number);

            Console.WriteLine();
        }
    }
}
