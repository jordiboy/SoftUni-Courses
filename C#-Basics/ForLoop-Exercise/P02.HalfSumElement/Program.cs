using System;

namespace P02.HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            int sumWithOutMax = sum - max;

            if (max == sumWithOutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumWithOutMax}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(max - sumWithOutMax)}");
            }
        }
    }
}
