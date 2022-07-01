using System;
using System.Linq;

namespace P02.SumDigits
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
                sum += number[i];
            }

            Console.WriteLine(sum);
        }
    }
}
