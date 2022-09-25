using System;
using System.Linq;
namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            string firstForArray = Console.ReadLine();
            string secondForArray = Console.ReadLine();

            char[] firstLetters = firstForArray.ToCharArray();
            char[] secondLetters = secondForArray.ToCharArray();
            int minLength;

            if (firstLetters.Length > secondLetters.Length)
            {
                minLength = secondLetters.Length;
            }
            else
            {
                minLength = firstLetters.Length;
            }

            bool equal = true;
            int biggestArray = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (!firstLetters[i].Equals(secondLetters[i]))
                {
                    equal = false;
                    if (firstLetters[i] > secondLetters[i])
                    {
                        biggestArray = 2;
                    }
                    else
                    {
                        biggestArray = 1;
                    }
                }
            }

            if ((!equal && biggestArray == 1) || (equal && firstLetters.Length <= secondLetters.Length))
            {
                Console.WriteLine(string.Join(string.Empty, firstLetters));
                Console.WriteLine(string.Join(string.Empty, secondLetters));
            }
            else if (!equal && biggestArray == 2 || (equal && firstLetters.Length > secondLetters.Length))
            {
                Console.WriteLine(string.Join(string.Empty, secondLetters));
                Console.WriteLine(string.Join(string.Empty, firstLetters));
            }
        }
    }
}
