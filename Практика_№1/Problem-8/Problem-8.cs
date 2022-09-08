using System;

namespace Problem_8
{
    class Program
    {
        static void Main()
        {
            //Problem-8

            float num_1, num_2, num_3, average;

            Console.WriteLine("Enter numbers to find average of the sum of them:\n");
            num_1 = float.Parse(Console.ReadLine());
            num_2 = float.Parse(Console.ReadLine());
            num_3 = float.Parse(Console.ReadLine());
            average = (num_1 + num_2 + num_3) / 3;
            Console.WriteLine("Average: " + average);
        }
    }
}
