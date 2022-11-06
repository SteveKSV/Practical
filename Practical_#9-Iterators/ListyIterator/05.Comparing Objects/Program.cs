using _05.Comparing_Objects;
using System;

internal class Program
{
    private static void Main()
    {
        string inputStr = Console.ReadLine();
        List<Person> people = new List<Person>();

        int countOfPeople = 0;
        while (inputStr != "END")
        {
            string[] inputArgs = inputStr.Split();

            people.Add(new Person(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));

            countOfPeople++;
            inputStr = Console.ReadLine();
        }

        int peopleInCollection = int.Parse(Console.ReadLine());

        if (peopleInCollection >= 2 && peopleInCollection <= 100)
        {
            int countOfEqualPeople = EqualPeople(people[peopleInCollection - 1], people);
            int countOfNotEqualPeople = NotEqualPeople(people[peopleInCollection - 1], people);


            if (countOfEqualPeople == 0 || countOfEqualPeople == 1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine($"{countOfEqualPeople} {countOfNotEqualPeople} {countOfPeople}");

        }
        else
        {
            Console.WriteLine("Input range [2...100]");
        }

    }

    private static int NotEqualPeople(Person person, List<Person> people)
    {
        var counter = 0;
        foreach (var currentPerson in people)
        {
            if (person.CompareTo(currentPerson) != 0)
            {
                counter++;
            }
        }

        return counter;
    }

    private static int EqualPeople(Person person, List<Person> people)
    {
        var counter = 0;
        foreach (var currentPerson in people)
        {
            if (person.CompareTo(currentPerson) == 0)
            {
                counter++;
            }
        }

        return counter;
    }
}