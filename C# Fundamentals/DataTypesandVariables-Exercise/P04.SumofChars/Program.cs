using System;

namespace P04.SumofChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                char character = char.Parse(Console.ReadLine());

                sum += character;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
