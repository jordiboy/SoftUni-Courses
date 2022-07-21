using System;

namespace P05.AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Division(sum, num3);
        }
        private static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        private static void Division(int sum, int num3)
        {
            Console.WriteLine(sum - num3);
        }
    }
}
