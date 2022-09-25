using System;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();

            foreach (var c in word)
            {
                Console.WriteLine($"{c} -> {c - 97}");
            }
        }
    }
}
