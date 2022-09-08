using System;

namespace Problem_17
{
    class Program
    {
        static void Main()
        {
            //Problem-17

            int n, factorial;
            factorial = 1;

            Console.WriteLine("Enter the number for factorial: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial is " + factorial);
        }
    }
}
