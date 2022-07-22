using System;

namespace P05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (IsZero(num1, num2, num3))
            {
                Console.WriteLine("zero");
            }
            else if (IsNegative(num1, num2, num3))
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
        private static bool IsZero(int num1, int num2, int num3)
        {
            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                return true;
            }
            return false;
        }
        private static bool IsNegative(int num1, int num2, int num3)
        {
            int[] arr = new int[] { num1, num2, num3 };

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    counter++;
                }
            }
            if (counter % 2 == 0)
            {
                return false;
            }
            return true;
        }
    }
}
