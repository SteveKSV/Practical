using System;

namespace Problem_15
{
    class Program
    {
        static void Main()
        {
            //Problem-15 

            int a, b, c;
            string product;

            Console.WriteLine("Enter numbers to find the signs:\n");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b < 0 && c > 0) || (a < 0 && b > 0 && c < 0))
            {
                product = "Positive";
                Console.WriteLine(product);
            }
            else if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c < 0))
            {
                product = "Negative";
                Console.WriteLine(product);
            }
        }
    }
}
