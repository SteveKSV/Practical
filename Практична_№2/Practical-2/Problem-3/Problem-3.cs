using System;

namespace Problem_3
{
    class Program 
    {     
        static void Main()
        {
            int n;

            Console.WriteLine("Enter the length of the array: ");
            n = int.Parse(Console.ReadLine());

            int[] inputArr = new int [n];

            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write($"Array[{i}] = ");
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nArray: ");
            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write($"{inputArr[i]}, ");
               
            }

            int k = inputArr.Length / 4;
            int[] newArr = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                newArr[i] = inputArr[k - (i + 1)] + inputArr[k + i];
                newArr[newArr.Length - 1 - i] = inputArr[newArr.Length - 1 - i + k] + inputArr[(newArr.Length - 1 - i) + (k + 2 * i + 1)];
            }

            Console.Write("\nNew array: ");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i] + " ");
            }
            
        }
    }
}
