/*
    1. Create a class Person (name, age);
    
    2. A person with the same name and age should be considered the same,
       override any methods needed to enforce this logic;

    3. Your class should work with both standard and hashed collections;
 
    4. Create a SortedSet and a HashSet of type Person;
 
 */

using _07.Equality_Logic;

SortedSet<Person> peopleSortedSet = new SortedSet<Person>();
HashSet<Person> peopleHashSet = new HashSet<Person>();

int n = int.Parse(Console.ReadLine());

if (n > 0 && n < 100)
{
    try
    {
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] inputArgs = input.Split();

            peopleSortedSet.Add(new Person(inputArgs[0], int.Parse(inputArgs[1])));
            peopleHashSet.Add(new Person(inputArgs[0], int.Parse(inputArgs[1])));
        }
       
        int counterForSortedSet = peopleSortedSet.Count();
        int counterForHashSet = peopleHashSet.Count();
        
        Console.WriteLine($"Count of DIFFERENT people in SortedSet = {counterForSortedSet}");
        Console.WriteLine($"Count of DIFFERENT people in HashSet = {counterForHashSet}");
        
        Console.WriteLine($"HashCode SortedSet People");
       
        foreach (var person in peopleSortedSet)
        {
            Console.WriteLine($"{person} -> HashCode = {person.GetHashCode()}");
        }

        Console.WriteLine($"HashCode HashSet People");

        foreach (var person in peopleHashSet)
        {
            Console.WriteLine($"{person} -> HashCode = {person.GetHashCode()}");
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}