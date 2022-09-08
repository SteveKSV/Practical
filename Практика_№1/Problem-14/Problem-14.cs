using System;

namespace Problem_14
{
    class Program
    {
        static void Main()
        {
            //Problem-14

            int a, b, c, result;
            Console.WriteLine("Enter three numbers to find the biggest of them:\n");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                result = a;
                Console.WriteLine("The biggest of numbers is " + result);
            }
            if (b > c && b > a)
            {
                result = b;
                Console.WriteLine("The biggest of numbers is " + result);
            }
            if (c > b && c > a)
            {
                result = c;
                Console.WriteLine("The biggest of numbers is " + result);
            }
        }
    }
}
