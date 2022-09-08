using System;

namespace Problem_11
{
    class Program
    {
        static void Main()
        {
            //Problem-11

            int number, N, nDigit;

            Console.WriteLine("Enter the number and N:");
            number = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());

            nDigit = number / (int)Math.Pow(10, N - 1) % 10;

            Console.WriteLine("The n-th digit of the number: ");
            if (nDigit == 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine(nDigit);
            }
        }
    }
}
