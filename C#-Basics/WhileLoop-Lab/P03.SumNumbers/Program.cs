using System;

namespace P03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < num)
            {
                int num1 = int.Parse(Console.ReadLine());
                sum += num1;
            }

            Console.WriteLine(sum);
        }
    }
}
