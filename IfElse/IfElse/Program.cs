using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любой символ");
            string input = Console.ReadLine();

            if (input == "") 
                return;

            char symbol = input[0];

            if (char.IsUpper(symbol))
                Console.WriteLine($"{symbol} — прописная буква");
            else if (char.IsLower(symbol))
                Console.WriteLine($"{symbol} — строчная буква");
            else if (char.IsDigit(symbol))
                Console.WriteLine($"{symbol} — цифра");
            else if (char.IsPunctuation(symbol))
                Console.WriteLine($"{symbol} — знак пунктуации");
            else
                Console.WriteLine($"{symbol} — специальный символ");

            Console.ReadKey();
        }
    }
}
