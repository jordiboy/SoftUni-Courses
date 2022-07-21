using System;

namespace P08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());

            FactorialDevision(num1, num2);
        }
        private static void FactorialDevision(double num1, double num2)
        {
            double factorial1 = 1;
            double factorial2 = 1;

            for (double i = num1; i >= 1; i--)
            {
                factorial1 *= i;
            }
            for (double i = num2; i >= 1; i--)
            {
                factorial2 *= i;
            }

            double devision = factorial1 / factorial2;

            Console.WriteLine($"{devision:f2}");
        }
    }
}
