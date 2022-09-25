using System;
using System.Linq;
namespace Problem_6
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int countOfFrequent = 0;
            int bestCount = 0;
            int index = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i+1])
                {
                    countOfFrequent++;
                    if (i + 1 == array.Length - 1 && bestCount < countOfFrequent)
                    {
                        bestCount = countOfFrequent;
                        index = i + 1;
                    }
                }
                else
                {
                    if (bestCount < countOfFrequent)
                    {
                        bestCount = countOfFrequent;
                        index = i;
                    }
                    countOfFrequent = 0;
                }
            }

            for (int i = 0; i < bestCount + 1; i++)
            {
                Console.Write(array[index] + " ");
            }
        }
    }
}
