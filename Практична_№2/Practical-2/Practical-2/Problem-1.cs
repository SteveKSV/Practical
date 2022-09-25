using System;
using System.Linq;
namespace Practical_2
{
    class Program
    {
        static void Main()
        { 
            string[] array_1 = Console.ReadLine().Split().ToArray();
            string[] array_2 = Console.ReadLine().Split().ToArray();

            Console.WriteLine("\n");

            int smallerArrayLength;

            if (array_1.Length < array_2.Length)
            {
                smallerArrayLength = array_1.Length;
            }
            else
            {
                smallerArrayLength = array_2.Length;
            }

            int countForFirstArray = 0;
            int countForSecondArray = 0;

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (array_1[i].Equals(array_2[i]))
                {
                    countForFirstArray++;
                } else { break;  }
            }

            Array.Reverse(array_1);
            Array.Reverse(array_2);

            for (int i = 0; i < smallerArrayLength; i++)
            {
                if (array_1[i].Equals(array_2[i]))
                {
                    countForSecondArray++;
                }
                else { break; }
            }

            Console.WriteLine(countForFirstArray > countForSecondArray ? countForFirstArray : countForSecondArray);
        }
    }
}
