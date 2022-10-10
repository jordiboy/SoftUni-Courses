using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool isEqual = false;
            
            if (numbers.Count == 1)
            {
                isEqual = true;
            }
            else
            {                
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        isEqual = true;
                    }
                    else
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            if (isEqual)
            {
                Console.WriteLine("No");
                return;
            }

            int sum = numbers.Sum();
            double average = (double)sum / numbers.Count;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= average)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            numbers.Sort();
            numbers.Reverse();

            if (numbers.Count - 1 > 5)
            {
                int range = numbers.Count - 5;
                numbers.RemoveRange(5, range);
            }

            Console.WriteLine(string.Join(" ", numbers));            
        }
    }
}
