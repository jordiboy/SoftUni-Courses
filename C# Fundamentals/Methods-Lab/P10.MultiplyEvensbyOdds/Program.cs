using System;
using System.Linq;

namespace P10.MultiplyEvensbyOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            var number = num.ToString()                
                .Select(x =>int.Parse(x.ToString()))
                .ToArray();

            int evenSum = EvenSum(number);
            int oddSum = OddSum(number);
            MultiplyEvenAndOdds(evenSum, oddSum);
        }
        public static int EvenSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
        public static int OddSum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }
        public static void MultiplyEvenAndOdds(int evenSum, int oddSum)
        {
            Console.WriteLine(evenSum * oddSum);
        }
    }
}
