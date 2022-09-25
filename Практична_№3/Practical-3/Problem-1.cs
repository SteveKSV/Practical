using System;

namespace Practical_3
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "Ivan";
            age = 20;
            Console.WriteLine("Default constructor: " + name + " " + age);
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
        
        public void Print()
        {
            Console.WriteLine($"Person: {name} {age}");
        }
    }


    class Program
    {
        static void Main()
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Stepan";
            firstPerson.Age = 18;
            firstPerson.Print();
        }
    }
}
