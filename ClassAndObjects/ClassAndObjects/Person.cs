using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

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

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public Person() : this("John", "Doe", 33) { }

        public string GetInfo() => $"{FullName}, возраст {Age}";

        //public void SetAge(int age)
        //{
        //    if (age < 1 || age > 150)
        //        throw new ArgumentException("Возраст должен быть от 1 до 150 лет");

        //    Age = age;
        //}
    }
}
