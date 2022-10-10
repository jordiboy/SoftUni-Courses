using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            List<int> result = new List<int>();

            for (int i = arrays.Length - 1; i >= 0; i--)
            {
                string arr = arrays[i];
                int[] temp = arr
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < temp.Length; j++)
                {
                    result.Add(temp[j]);                    
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
