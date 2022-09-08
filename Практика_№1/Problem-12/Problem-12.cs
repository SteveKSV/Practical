using System;

namespace Problem_12
{
    class Program
    {
        static void Main()
        {
            //Problem - 12
            Console.WriteLine("Enter the number for check: ");

            int numberForProblem11 = int.Parse(Console.ReadLine());

            if (numberForProblem11 > 20 && (numberForProblem11 % 10 != 0))
            {
                Console.WriteLine("True, the number is greater than 20 and odd");
            }
            else
            {
                Console.WriteLine("False, the number isn't greater than 20 and isn't odd");
            }
        }
    }
}
