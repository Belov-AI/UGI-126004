using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brackets = new Dictionary<char, char>();
            brackets[')'] = '(';
            brackets[']'] = '[';
            brackets['}'] = '{';

            Console.WriteLine("Введите выражение со скобками");
            var expression = Console.ReadLine();

            if (IsCorrect(expression, brackets))
                Console.WriteLine("Скобки расставлены верно");
            else
                Console.WriteLine("Скобки расставлены неверно");

            Console.ReadKey();
        }

        static bool IsCorrect(string expression, Dictionary<char,char> brackets)
        {
            var stack = new Stack<char>();

            for (var i = 0; i < expression.Length; i++)
            {
                var c = expression[i];

                if (brackets.ContainsValue(c))
                    stack.Push(c);
                else if (brackets.ContainsKey(c))
                    if (stack.Count == 0 || stack.Pop() != brackets[c])
                        return false;
            }

            return stack.Count == 0;
        }
    }
}
