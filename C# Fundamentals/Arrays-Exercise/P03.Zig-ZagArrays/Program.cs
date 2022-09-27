using System;
using System.Linq;

namespace P03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[n];
            int[] array2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                

                if (i % 2 != 0)
                {
                    array1[i] = input[0];
                    array2[i] = input[1];
                }
                if (i % 2 == 0)
                {
                    array2[i] = input[0];
                    array1[i] = input[1];
                }
            }

            Console.Write(string.Join(" ", array2));
            Console.WriteLine();
            Console.Write(string.Join(" ", array1));
        }
    }
}
