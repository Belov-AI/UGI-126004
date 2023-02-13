using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mike = new Person();
            mike.Name = "Михаил";
            mike.Surname = "Петров";
            mike.Age = 18;
            //PrintPerson(mike);

            var kate = new Person { Name = "Екатерина", Surname = "Иванова", Age = 17 };
            //PrintPerson(kate);

            var people = new[] { mike, kate };

            foreach(var person in people)
                PrintPerson(person);

            Console.ReadKey();
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine($"{person.Name} {person.Surname}, возраст {person.Age}");
        }
    }
}
