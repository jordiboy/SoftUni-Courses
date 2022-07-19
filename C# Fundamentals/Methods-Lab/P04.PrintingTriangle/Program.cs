using System;

namespace P04.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Triangle(n);
        }
        public static void Triangle(int n)
        {
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
