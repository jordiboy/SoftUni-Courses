using System;

namespace P04.RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;

                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{number} -> true");
                }
                else
                {
                    Console.WriteLine($"{number} -> false");
                }
            }
        }
    }
}
