using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strategy_Pattern
{
    public class Person
    {
        string name;
        int age;
        public string Name
        {
            get { return name; }
            set
            {
                if(value.Length < 1 && value.Length > 100)
                {
                    throw new ArgumentException("Invalid name!");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || (value < 1 && value > 100))
                {
                    throw new ArgumentException("Invalid age!");
                }
                age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
