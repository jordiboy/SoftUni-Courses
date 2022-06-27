using System;

namespace P12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (true)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(num)}");
                    break;
                }

                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
