using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "a", "abc", "ab", "a", "aba", "ab", "a", "b" };

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if(dict.ContainsKey(word))
                    dict[word]++;
                else
                    dict[word] = 1;
            }

            PrintDictionary(dict);

            Console.WriteLine();

            var sortedDict = new SortedDictionary<string, int>(dict);
            
            PrintDictionary(sortedDict);

            Console.ReadKey();
        }

        static void PrintDictionary(IDictionary<string, int> dic)
        {
            //foreach (var elem in dic)
            //    Console.WriteLine($"{elem.Key}\t{elem.Value}");
            foreach (var key in dic.Keys)
                Console.WriteLine($"{key}\t{dic[key]}");
        }        
    }
}
