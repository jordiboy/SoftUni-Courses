using System;
using System.Linq;

namespace P10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            TopNumber(n);
        }
        private static void TopNumber(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var number = i.ToString()
                    .Select(x => int.Parse(x.ToString()))
                    .ToArray();

                int sumDigits = 0;
                int odd = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    sumDigits += number[j];

                    if (number[j] % 2 != 0)
                    {
                        odd++;
                    }
                }                

                if (sumDigits % 8 == 0 && odd > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
