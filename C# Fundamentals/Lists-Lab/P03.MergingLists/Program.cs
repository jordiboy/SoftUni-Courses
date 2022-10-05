using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> result = new List<int>();

            int length = 0;
            int length1 = 0;

            if (numbers1.Count > numbers2.Count)
            {
                length = numbers2.Count;
                length1 = numbers1.Count;
            }
            else
            {
                length = numbers1.Count;
                length1 = numbers2.Count;
            }

            for (int i = 0; i < length; i++)
            {
                result.Add(numbers1[i]);
                result.Add(numbers2[i]);
            }

            for (int i = length; i < length1; i++)
            {
                if (numbers1.Count == length1)
                {
                    result.Add(numbers1[i]);
                }
                else if (numbers2.Count == length1)
                {
                    result.Add(numbers2[i]);
                }
                
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
