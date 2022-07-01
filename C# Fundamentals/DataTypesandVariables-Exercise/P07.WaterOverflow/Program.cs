using System;

namespace P07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                int litters = int.Parse(Console.ReadLine());

                if (total + litters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");                    
                }
                else
                {
                    total += litters;
                }
            }

            Console.WriteLine(total);
        }
    }
}
