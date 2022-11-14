using System;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите позицию белой пешки");
            string whitePownPosition = Console.ReadLine();

            if(!CheckWhitePownPosition(whitePownPosition))
            {
                Console.WriteLine("Позиция белой пешки не корректина");
                Console.ReadKey();
                return;
            }

            
            Console.ReadKey();
        }

        static bool CheckWhitePownPosition(string position)
        {
            throw new NotImplementedException();
        }
    }
}
