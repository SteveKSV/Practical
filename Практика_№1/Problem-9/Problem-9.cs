using System;

namespace Problem_9
{
    class Program
    {
        static void Main()
        {
            //Problem-9

            float side_1, side_2, height, area;
            Console.WriteLine("Enter the base sides and height of trapezoid:\n");
            side_1 = float.Parse(Console.ReadLine());
            side_2 = float.Parse(Console.ReadLine());
            height = float.Parse(Console.ReadLine());
            area = (side_1 + side_2) / 2 * height;
            Console.WriteLine("Result: " + area + "\n");
        }
    }
}
