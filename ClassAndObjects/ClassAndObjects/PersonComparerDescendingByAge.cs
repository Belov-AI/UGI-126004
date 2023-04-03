using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    public class PersonComparerDescendingByAge : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return y.Age - x.Age;
        }
    }
}
