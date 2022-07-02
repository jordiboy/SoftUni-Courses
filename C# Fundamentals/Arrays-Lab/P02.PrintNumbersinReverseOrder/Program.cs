using System;

namespace P02.PrintNumbersinReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length - 1; i > -1 ; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
