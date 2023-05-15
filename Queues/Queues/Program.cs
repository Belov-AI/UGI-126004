using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество знаков числа");
            var k = int.Parse(Console.ReadLine());
            int min = (int)Math.Pow(10, k - 1);
            int max = (int)Math.Pow(10, k); 

            Console.WriteLine("Введиьте количество чисел");
            var n = int.Parse(Console.ReadLine());

            var numbers = new SortedDictionary<int, Queue<int>>();

            var random = new Random();

            for(var i = 0; i < n;  i++)
            {
                var number = random.Next(min, max);
                var key = number % 10;

                if(!numbers.ContainsKey(key))
                    numbers[key] = new Queue<int>();
                 
                numbers[key].Enqueue(number);
            }

            foreach(var key in numbers.Keys)
                Print(numbers[key]);

            Console.ReadKey();
        }

        static void Print(IEnumerable<int> nums)
        {
            Console.WriteLine();

            foreach (var num in nums)
                Console.Write($"{num} ");

            Console.WriteLine();
        }
    }
}
