using System;
using System.Linq;

namespace P01.SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] numbers = new int[3] { num1, num2, num3 };

            SmallerNumber(numbers);
        }
        private static void SmallerNumber(int[] numbers)
        {
            Console.WriteLine(numbers.Min());
        }
    }
}
