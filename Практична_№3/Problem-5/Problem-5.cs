using System;
using System.Globalization;
namespace Problem_5
{
    class DateModifier
    {
        public static long DifferenceForTwoDates(string firstDate, string secondDate)
        {
            var date_1 = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            var date_2 = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

            var differenceBetween = Math.Abs((date_1 - date_2).Days);
            return differenceBetween;
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first date: ");
            string firstDate = Console.ReadLine();

            Console.WriteLine("Enter the second date: ");
            string secondDate = Console.ReadLine();

            var result = DateModifier.DifferenceForTwoDates(firstDate, secondDate);
            Console.WriteLine("Difference between two dates days: " + result);
        }
    }
}
