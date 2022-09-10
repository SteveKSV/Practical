using System;

namespace Problem_7
{
    class Program
    {
        static void Main()
        {
            // Problem-4
            Console.WriteLine("Red");

            //Problem-5
            sbyte a = -100;
            byte b = 128;
            short c = -3540;
            ushort d = 64876;
            uint e = 2147483648;
            int f = -1141583228;
            long g = -1223372036854775808;

            Console.WriteLine("\nInteger numbers:\n " + a + " " + b + " " + c + " " + d + " " + e + " " + f + " " + g);

            //Problem-6
            double number1 = 3.141592653589793238;
            double number2 = 1.60217657;
            double number3 = 7.8184261974584555216535342341;

            Console.WriteLine("\nFloating point numbers: \n" + number1 + " " + number2 + " " + number3);

            //Problem-7
            string line_1 = "Software University";
            char character_1 = 'B';
            char character_2 = 'y';
            char character_3 = 'e';
            string line_2 = "I love programming";

            Console.WriteLine("\nCharacters and strings:");
            Console.WriteLine(line_1 + "\n" + character_1 + "\n" + character_2 + "\n" + character_3 + "\n" + line_2);
        }
    }
}
