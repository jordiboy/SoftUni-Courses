using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();            

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers.Count >= 2)
                {
                    result.Add(numbers[i] + numbers[numbers.Count - 1]);
                    numbers.RemoveAt(i);
                    numbers.RemoveAt(numbers.Count - 1);
                    i = -1;
                }
                else
                {
                    result.Add(numbers[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
