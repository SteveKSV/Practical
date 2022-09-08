using System;

namespace Problem_13
{
    class Program
    {
        static void Main()
        {
            //Problem - 13

            int n;
            Boolean result;

            Console.WriteLine("Enter the number for check: ");
            n = int.Parse(Console.ReadLine());

            if (n % 9 == 0 || n % 11 == 0 || n % 13 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            if (result)
            {
                Console.WriteLine("The number is divided by 9, 11 or 13 without remainder");
            } else
            {
                Console.WriteLine("The number isn't divided by 9, 11 or 13 without remainder");
            }
            
        }
    }
}
