using System;
using System.Linq;

namespace P06.Strongnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            var number = num.ToString()
                .Select(x => int.Parse(x.ToString()))
                .ToArray();

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int factorial = 1;

                for (int j = 1; j <= number[i]; j++)
                {
                    factorial *= j;
                }

                sum += factorial;
            }

            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
