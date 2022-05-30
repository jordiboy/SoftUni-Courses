using System;

namespace P10.Multiplyby2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;

            while (num >= 0)
            {
                num = double.Parse(Console.ReadLine());

                if (num >= 0)
                {
                    num *= 2;
                    Console.WriteLine($"Result: {num:f2}");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Negative number!");
        }
    }
}
