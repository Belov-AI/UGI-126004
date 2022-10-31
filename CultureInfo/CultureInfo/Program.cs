using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureInfoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintCultureInfo(CultureInfo.CurrentCulture.Name);
            PrintCultureInfo("en-GB");
            PrintCultureInfo("en-US");
            PrintCultureInfo(CultureInfo.InvariantCulture.Name);
            PrintCultureInfo("de-DE");

            Console.ReadKey();
        }

        static void PrintCultureInfo(string name)
        {
            var oldCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = new CultureInfo(name);

            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            var x = 1.234556;
            Console.WriteLine(x);
            var dt = DateTime.Now;
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine();

            CultureInfo.CurrentCulture = oldCulture;
        }
    }
}
