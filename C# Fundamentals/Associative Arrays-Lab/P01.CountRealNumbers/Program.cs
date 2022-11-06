using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var nums = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!nums.ContainsKey(number))
                {
                    nums.Add(number, 0);
                }

                nums[number]++;
            }

            foreach (var number in nums)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
