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
            var kate = new Person("Екатерина", "Иванова", Gender.Female, 17);
            kate.Gender = Gender.Female;

            //if (kate.Gender == Gender.Female)
            //    Console.WriteLine($"{kate.Name} - женщина");
            //else if (kate.Gender == Gender.M)
            //    Console.WriteLine($"{kate.Name} - мужчина");

            Console.WriteLine($"{kate.Name} - {kate.Gender.ToString().ToLower()}");
            Console.WriteLine((int)kate.Gender);


            //kate.SetAge(17);
            //PrintPerson(kate);

            var john = new Person();
            john = new Person("John", "Smith", Gender.Male, 24);
            var helen = new Person("Елена", "Иванова", Gender.Female, 20);
            var ekaterina = new Person("Екатерина", "Иванова", Gender.Female, 18);

            var people = new[] { ekaterina, helen, mike, kate, john };
            PrintPersonArray(people);

            Array.Sort(people);
            PrintPersonArray(people);

            Array.Sort(people, new PersonComparerDescendingByAge());
            PrintPersonArray(people);

            Array.Sort(people, new PersonComparerByName());
            PrintPersonArray(people);

            Console.ReadKey();
        }

        private static void PrintPersonArray(Person[] people)
        {
            Console.WriteLine();

            foreach (var person in people)
                PrintPerson(person);
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine(person.GetInfo());
        }
    }
}
