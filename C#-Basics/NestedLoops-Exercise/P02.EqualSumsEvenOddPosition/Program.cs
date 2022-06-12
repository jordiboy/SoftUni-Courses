using System;

namespace P02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                string currnum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;

                for (int j = 0; j < currnum.Length; j++)
                {
                    int currDigit = int.Parse(currnum[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currDigit;
                    }
                    else
                    {
                        oddSum += currDigit;
                    }
                }

                if (oddSum == evenSum)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
