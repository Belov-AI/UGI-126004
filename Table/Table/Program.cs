using System;

namespace Table
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число строк таблицы");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов таблицы");
            var n = int.Parse(Console.ReadLine());

            var table = new int[m, n];
            var rnd = new Random();

            for(var i = 0; i < table.GetLength(0); i++)
                for(var j = 0; j < table.GetLength(1); j++)
                    table[i, j] = rnd.Next(100);

            PrintTable(table);
            PrintTwoDigitsTable(table);

            Console.ReadKey();
        }

        static void PrintTable(int[,] t)
        {
            for(var i = 0; i < t.GetLength(0); i++)
            {
                for (var j = 0; j < t.GetLength(1); j++)
                    Console.Write($"{t[i, j],2} ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void PrintTwoDigitsTable(int[,] t)
        {
            var notPrint = false;

            for (var i = 0; i < t.GetLength(0); i++)
            {
                if (notPrint)
                    break;

                for (var j = 0; j < t.GetLength(1); j++)
                    if (t[i, j] < 10)
                    {
                        notPrint = true;
                        break;
                    }
                    else
                        Console.Write($"{t[i, j],2} ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
