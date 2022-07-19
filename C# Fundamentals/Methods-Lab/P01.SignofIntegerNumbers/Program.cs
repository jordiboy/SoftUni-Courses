using System;

namespace P01.SignofIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Sign(num);
        }
        public static void Sign(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        }
    }
}
