using System;

namespace P08.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int couples = int.Parse(Console.ReadLine());

            int value = 0;
            int diff = 0;

            int[] sumOfCouples = new int[couples];

            for (int i = 0; i < couples; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                sumOfCouples[i]= num1 + num2;                

            }
            if (sumOfCouples.Length > 1)
            {
                for (int i = 0; i < sumOfCouples.Length - 1; i++)
                {
                    int num1, num2, currdiff;

                    num1 = sumOfCouples[i];
                    num2 = sumOfCouples[i + 1];

                    if (num1 == num2)
                    {
                        value = num1;
                    }
                    else
                    {
                        currdiff = Math.Abs(num1 - num2);

                        if (currdiff > diff)
                        {
                            diff = currdiff;
                        }
                    }
                }
            }
            else
            {
                value = sumOfCouples[0];
            }

            if (diff == 0)
            {
                Console.WriteLine($"Yes, value={value}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
