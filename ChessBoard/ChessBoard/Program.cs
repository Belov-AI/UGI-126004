using System;


namespace Chessboard
{
    class Program
    {
        static ConsoleColor lightColor = ConsoleColor.Yellow;
        static ConsoleColor darkColor = ConsoleColor.Red;
        static void Main()
        {
            int boardSize = 0;

            //Здесь ввод размера доски.
            //оформите его в виде бесконечного цикла с проверкой,
            //что 1<= boardSize <= 26
            //и предложением повторного ввода, если условие не выполняется
            //Предусмотрите отказ от ввода (с последующим завершением программы).

            Console.WriteLine("Введите размер доски от 1 до 26. Enter - отказ от ввода");

            string input;

            while (true)
            {
                input = Console.ReadLine();

                if (input == "")
                    break;
                //try
                //{
                //    boardSize = int.Parse(input);
                //}
                //catch(Exception e)
                //{
                //    Console.WriteLine(e.Message);
                //    Console.WriteLine("Повторите ввод");
                //    continue;
                //}

                if(!int.TryParse(input, out boardSize))
                {
                    Console.WriteLine("Ошибка. Повторите ввод");
                    continue;
                }

                if( boardSize < 1 || boardSize > 26)
                {
                    Console.WriteLine("Введите размер доски от 1 до 26.");
                    continue;
                }

                break;
            }

            if (input == "")
                return;

            PrintBoard(boardSize);

            Console.ReadKey();
        }

        static void PrintBoard(int size)
        {
            //написать метод печати шахматной доски размера (size x size)
            PrintHeader(size);

            for (var row = size; row > 0; row--)
            {
                Console.Write($"{row,2}");

                ConsoleColor firstColor, secondColor;

                if (row % 2 == 0)
                {
                    firstColor = lightColor;
                    secondColor = darkColor;
                }
                else
                {
                    firstColor = darkColor;
                    secondColor = lightColor;
                }

                for (var i = 0; i < size; i++)
                    if (i % 2 == 0)
                        PrintSquare(firstColor);
                    else
                        PrintSquare(secondColor);

                Console.WriteLine(row);
            }

            PrintHeader(size);
        }

        static void PrintHeader(int size)
        {
            Console.Write("  ");

            for(var i = 0; i < size; i++)
                Console.Write((char)(0x61 + i));

            Console.WriteLine();
        }

        /// <summary>
        /// Печать квадрата нужного цвета
        /// </summary>
        /// <param name="color">Цвет квадрата</param>
        static void PrintSquare(ConsoleColor color)
        {
            const char square = (char)0x2588;

            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(square);
            Console.ForegroundColor = defaultColor;
        }
    }
}
