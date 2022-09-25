using System;
using System.Collections.Generic;
namespace Problem_3
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
    public class Family
    {
        public Family()
        {
            this.People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public Person GetOldestMember(List<Person> people)
        {
            var currentPerson = new Person(); 
            
            foreach (var s in people)
            {
                if (currentPerson.Age < s.Age)
                {
                    currentPerson = s;
                }
            }
            return currentPerson;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of the family members: ");
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();
            Console.WriteLine($"Enter members of the family({n} members): ");
            for (int i = 0; i < n; i++)
            {
                string[] inputForMember = Console.ReadLine().Split();
                Person newMember = new Person(inputForMember[0], int.Parse(inputForMember[1]));
                family.AddMember(newMember);

            }

            Person oldest = new Person();
            if (family.People.Count > 0)
            {
                oldest = family.GetOldestMember(family.People);
            }

            Console.WriteLine("Oldest of the Family is: " + oldest.Name + " " + oldest.Age);
        }
    }
}
