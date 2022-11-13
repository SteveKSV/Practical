using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Comparing_Objects
{
    internal class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }
        public int CompareTo(Person person)
        {
            var resultFromCompare = this.Name.CompareTo(person.Name);
            if (resultFromCompare == 0)
            {
                resultFromCompare = this.Age.CompareTo(person.Age);
            }

            if (resultFromCompare == 0)
            {
                resultFromCompare = this.Town.CompareTo(person.Town);
            }

            return resultFromCompare;
        }
    }
}
