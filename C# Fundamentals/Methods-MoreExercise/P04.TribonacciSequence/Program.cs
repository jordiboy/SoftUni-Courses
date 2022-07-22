using System;

namespace P04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Tribonacci(num);
        }
        private static void Tribonacci(int num)
        {
            int first = 1;
            int second = 1;
            int third = 2;
            int sum;

            for (int i = 1; i <= num; i++)
            { 
                if (i < 3)
                {                    
                    Console.Write($"1 ");
                }
                else if (i == 3)
                {
                    Console.Write($"2 ");
                }
                else
                {
                    sum = first + second + third;
                    first = second;
                    second = third;
                    third = sum;

                    Console.Write($"{sum} ");
                }
            }
        }
    }
}
