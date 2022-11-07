using System;

namespace Logic
{
    class Program
    {
        static void Main()
        {
            var x = Input("x");
            var y = Input("y");

            Console.WriteLine($"!x = {!x}, !y = {!y}\nx | y = {x || y}, x & y = {x && y}, x ^ y = {x ^ y}");

            Console.ReadKey();
        }

        private static bool Input(string name)
        {
            Console.WriteLine($"Введите {name}:");
            var logicalValue = bool.Parse(Console.ReadLine());
            Console.WriteLine(logicalValue);
            return logicalValue;
        }
    }
}
