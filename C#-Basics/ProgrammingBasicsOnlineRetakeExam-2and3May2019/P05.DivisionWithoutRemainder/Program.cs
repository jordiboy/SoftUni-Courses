using System;

namespace P05.DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] counter = new double[3];

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    counter[0]++;
                }
                if (num % 3 == 0)
                {
                    counter[1]++;
                }
                if (num % 4 == 0)
                {
                    counter[2]++;
                }
            }

            Console.WriteLine($"{(counter[0] / n) * 100:f2}%");
            Console.WriteLine($"{(counter[1] / n) * 100:f2}%");
            Console.WriteLine($"{(counter[2] / n) * 100:f2}%");
        }
    }
}
