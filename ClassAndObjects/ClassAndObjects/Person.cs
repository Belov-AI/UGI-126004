using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    public class Person : IComparable<Person>
    {
        public static readonly string Species;
        public string Name { get; set; }
        public string Surname { get; set; }

        public Gender Gender { get; set; }

        public string FullName
        {
            get { return $"{Name} {Surname}"; }
        }
        
        private int age;
        public int Age
        {
            get { return age; }

            set 
            { 
                if(value < 1 || value >150)
                    throw new ArgumentException("Возраст должен быть от 1 до 150 лет");
                
                age = value; 
            }
        }

        public Person(string name, string surname, Gender gender, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        public Person() : this("John", "Doe", Gender.Male, 33) { }

        static Person()
        {
            Species = "homo sapience";
        }

        ~Person()
        {
            Console.WriteLine($"объект {FullName} удален");
        }

        public string GetInfo() => $"{FullName}, возраст {Age}";

        public int CompareTo(Person other)
        {
            if(Surname != other.Surname)
                return Surname.CompareTo(other.Surname);

            if(Name != other.Name)
                return Name.CompareTo(other.Name);
            
            return Age.CompareTo(other.Age);
        }
    }
}
