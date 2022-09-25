using System;


namespace Problem_2
{

    class Person
    {
        private readonly string name;
        private readonly int age;

        public Person()
        {
            name = "No name";
            age = 1;
        }

        public Person(int age)
        {
            this.age = age;
            name = "No name";
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age; 
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
            Console.WriteLine("First constructor");
            Person firstPerson = new Person();
            firstPerson.Print();

            Console.WriteLine("\nSecond constructor");
            Person secondPerson = new Person(18);
            secondPerson.Print();

            Console.WriteLine("\nThird constructor");
            Person thirdPerson = new Person("Stepan", 18);
            thirdPerson.Print();
        }
    }
}
