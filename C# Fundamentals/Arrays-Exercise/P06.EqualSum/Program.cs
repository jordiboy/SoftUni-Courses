using System;
using System.Linq;

namespace P06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isNotFound = false;
            int element = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int leftsum = 0;
                int rightSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftsum += array[j];                   
                }

                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftsum == rightSum)
                {
                    element = i;
                    isNotFound = false;
                    break;
                }
                else
                {
                    isNotFound = true;
                }
            }

            if (isNotFound)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}
