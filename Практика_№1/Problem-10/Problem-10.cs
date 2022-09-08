using System;

namespace Problem_10
{
    class Program
    {
        static void Main()
        {
            //Problem-10

            int n, lastDigit;

            Console.WriteLine("Enter the number: ");
            n = int.Parse(Console.ReadLine());

            lastDigit = n % 10;
            Console.WriteLine("Last Digit of the number: " + lastDigit);
        }
    }
}
