using System;

namespace IntLogical
{
    internal class Program
    {
        static void Main()
        {
            var x = Input("x");
            var y = Input("y");

            PrintResult(~x, "~x");
            PrintResult(x & y, "x & y");
            PrintResult(x | y, "x | y");
            PrintResult(x ^ y, "x ^ y");

            Console.ReadKey();
        }

        private static void PrintResult(int number, string name)
        {
            Console.WriteLine($"{name} = {Convert.ToString(number, 2)}");
        }

        static int Input(string name)
        {
            Console.WriteLine($"Введите {name}:");
            var number = Convert.ToInt32(Console.ReadLine(),16);
            Console.WriteLine($"{name} = {Convert.ToString(number, 2)}\n");
            return number;
        }
    }
}
