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
            Console.WriteLine(Person.Species);
            Console.WriteLine(mike.FullName);
            //mike.SetAge(18);
            //PrintPerson(mike);

            //var kate = new Person { Name = "Екатерина", Surname = "Иванова", Age =17};
            var kate = new Person("Екатерина", "Иванова", 17);

            //kate.SetAge(17);
            //PrintPerson(kate);

            var john = new Person();
            john = new Person("John", "Smith", 24);

            var people = new[] { mike, kate, john };

            foreach(var person in people)
                PrintPerson(person);

            Console.ReadKey();
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine(person.GetInfo());
        }
    }
}
