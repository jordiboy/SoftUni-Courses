using System;

namespace P03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumPrimes = 0;
            int sumNonPrimes = 0;
            string input;

            while ((input = Console.ReadLine()) != "stop")
            {
                int currnum = int.Parse(input);

                if (currnum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                else if (currnum == 0)
                {
                    sumNonPrimes += currnum;
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i < currnum; i++)
                {
                    if (currnum % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrimes += currnum;
                }
                else
                {
                    sumNonPrimes += currnum;
                }
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrimes}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimes}");
        }
    }
}
