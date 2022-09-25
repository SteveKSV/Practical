using System;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            int n;

            Console.WriteLine("Enter the length of the array:");
            
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter the number of rotates of the array: ");
            int rotate = int.Parse(Console.ReadLine());

            int[] sumResult = new int[arr.Length];

            for (int i = 0; i < rotate; i++)
            {
                int lastElement = arr[arr.Length - 1];

                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }

                arr[0] = lastElement;

                for (int w = 0; w < arr.Length; w++)
                {
                    sumResult[w] += arr[w];
                }
            }

            for (int i = 0; i < sumResult.Length; i++)
            {
                Console.Write(sumResult[i] + " ");
            }
            
        }
    }
}
