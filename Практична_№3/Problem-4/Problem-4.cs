using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_4
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.age = 1;
            this.name = "No name";
        }
        public Person(int age)
        {
            this.age = age;
            this.name = "No name";
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
    class Program
    {
        static void Main()
        {
            var people = new List<Person>();

            Console.Write("Enter the number of people: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] nameAge = Console.ReadLine().Split();
                string name = nameAge[0];
                int age = int.Parse(nameAge[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            people.RemoveAll(people => people.Age < 30);

            people.Sort((left, right) => left.Name.CompareTo(right.Name));
            Console.WriteLine("\n");
            foreach (Person p in people)
            {
                Console.WriteLine( p.Name + " - " + p.Age);
            }

        }
    }
}
