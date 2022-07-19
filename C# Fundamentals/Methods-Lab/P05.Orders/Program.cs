using System;

namespace P05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            int count = int.Parse(Console.ReadLine());
            TotalPrice(product, count);
        }
        public static void TotalPrice(string product, int count)
        {
            double price = 0;

            switch (product)
            {
                case "coffee": price = 1.5; break;
                case "water": price = 1; break;
                case "coke": price = 1.4; break;
                case "snacks": price = 2; break;                
            }

            Console.WriteLine($"{price * count:f2}");
        }
    }
}
