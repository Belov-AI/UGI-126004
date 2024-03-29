﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersAndStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = (char)0x42F;
            Console.WriteLine(letter);

            var newLetter = char.ToLower(letter);
            Console.WriteLine();
            Console.WriteLine(newLetter);
            Console.WriteLine(letter);

            string s = "Hello, World";
            letter = s[7];
            Console.WriteLine();
            Console.WriteLine(letter);

            var text = s + "!";
            Console.WriteLine(text);
            Console.WriteLine(text.Length);
            Console.WriteLine(text.Substring(7));
            Console.WriteLine(text.Substring(7, 5));
            var words = text.Split();
            Console.WriteLine(words[0]);
            Console.WriteLine(words[1]);

            string newString = "\"Hello, World\"";
            Console.WriteLine(newString);
            newString += "\r\"G'bye";
            Console.WriteLine(newString);
            Console.WriteLine("\xAE");
            Console.WriteLine("aa\bz");
            Console.WriteLine(@"C:\Windows\System32\drivers");
            Console.WriteLine(@"Первая строка
Вторая строка");
            var x = 12.345689;
            Console.WriteLine("{0:G} {0:F3} {0:E} {0:P} {0:C}", x);
            Console.WriteLine("{0} {0:X}", (int)'Я');
            Console.WriteLine($"Текущее время {DateTime.Now:HH:mm dd.MM.yyyy}");
            Console.ReadKey();
        }
    }
}
