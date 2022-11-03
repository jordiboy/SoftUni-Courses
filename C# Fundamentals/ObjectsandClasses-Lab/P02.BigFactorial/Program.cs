using System;
using System.Numerics;

namespace P02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (BigInteger i = num; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
