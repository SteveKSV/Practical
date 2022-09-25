using System;
using System.Linq;
namespace Problem_5
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCount = 0;
            int mostFrequent = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = array[i];
                }
            }
            Console.WriteLine("Most Frequent = " + mostFrequent);
        }
    }
}
