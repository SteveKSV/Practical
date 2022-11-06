/* 1. Create Person (name, age);
 * 
   2. Create 2 Comparators for Person (implement IComparer<Person>);

   3. The first comparator should compare people based on the length of their name as first parametr;
        3.1. If 2 people have a name with the same length, perform a case-insensitive compare based on the
             first letter of their name instead;

   4.  The second comparator should compare them based on their age;

   5. Create 2 SortedSets of type Person, the first should implement the name comparator and the second should
      implement the age comparator;
 */

using _06.Strategy_Pattern;
using _06.Strategy_Pattern.Comparators;
using System.Collections.Generic;

SortedSet<Person> peopleSortedByNameLength = new SortedSet<Person>(new NameComparator());
SortedSet<Person> peopleSortedByAge = new SortedSet<Person>(new AgeComparator());
int n = int.Parse(Console.ReadLine());

if (n > 0 && n < 100)
{
    try
    {
        for (int i = 0; i < n; i++)
        {

            string input = Console.ReadLine();
            string[] inputArgs = input.Split();

            peopleSortedByNameLength.Add(new Person(inputArgs[0], int.Parse(inputArgs[1])));
            peopleSortedByAge.Add(new Person(inputArgs[0], int.Parse(inputArgs[1])));


        }

        Console.WriteLine("---NameLength Comparator---");
        foreach (Person person in peopleSortedByNameLength)
            Console.WriteLine(person);

        Console.WriteLine("---Age Comparator---");
        foreach (Person person in peopleSortedByAge)
            Console.WriteLine(person);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}


