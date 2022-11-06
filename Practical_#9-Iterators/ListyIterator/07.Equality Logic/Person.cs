using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Equality_Logic
{

    public class Person : IComparable<Person>
    {
        string name;
        int age;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 1 && value.Length > 50)
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

        public override bool Equals(Object obj)
        {
            if (obj is Person)
            {
                Person p = (Person)obj;
                return this.Name == p.Name && this.Age == p.Age;
            }
            else
            {
                return false;
            }
        }

        public int CompareTo(Person other)
        {
            var result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }

            return result;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Age.GetHashCode();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
