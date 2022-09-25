using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int len = n + 1;
            int[] primes = new int[len];
            for (int i = 0; i < len; i++)
                primes[i] = i;

            for (int i = 2; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (primes[j] == 0)
                        continue;
                    if (j % i == 0)
                    {
                        primes[j] = 0;
                        continue;
                    }
                }
            }
            for (int i = 0; i < len; i++)
                if (primes[i] != 0)
                    Console.WriteLine(primes[i]);
        }
    }
}
