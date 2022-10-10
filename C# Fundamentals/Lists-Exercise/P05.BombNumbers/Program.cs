using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BombNumbers       // 75/100
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] bombNums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNums[0])
                {
                    if (i + bombNums[1] > numbers.Count - 1)
                    {
                        numbers.RemoveRange(i - bombNums[1], numbers.Count - i + bombNums[1]);
                        i = 0;
                    }
                    else if (i - bombNums[1] < 0)
                    {
                        numbers.RemoveRange(0, i + bombNums[1] + 1);
                        i = 0;
                    }
                    else
                    {
                        numbers.RemoveRange(i - bombNums[1], 2 * bombNums[1] + 1);
                        i = 0;
                    }
                    
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
