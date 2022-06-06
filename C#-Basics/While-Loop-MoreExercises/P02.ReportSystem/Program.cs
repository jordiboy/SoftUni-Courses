using System;

namespace P02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSum = int.Parse(Console.ReadLine());
            
            int[] counter = new int[3];             // i0 = counterTransactions; i1 = counterCards; i2 = counterCash
            int sumCash = 0;
            int sumCard = 0;
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                int currSum = int.Parse(input);

                counter[0]++;

                if (counter[0] % 2 == 0)
                {
                    //Card
                    if (currSum < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sumCard += currSum;
                        counter[1]++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    //Cash
                    if (currSum > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sumCash += currSum;
                        counter[2]++;
                        Console.WriteLine("Product sold!");
                    }
                }

                if (sumCard + sumCash >= targetSum)
                {
                    break;
                }
            }

            double avgCash = (double)sumCash / counter[2];
            double avgCard = (double)sumCard / counter[1];

            if (sumCard + sumCash >= targetSum)
            {
                Console.WriteLine($"Average CS: {avgCash:f2}");
                Console.WriteLine($"Average CC: {avgCard:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
