using System;

namespace P02.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double priceDresses = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            priceDresses *= countStatists;

            if (countStatists >= 150)
            {
                double discount = priceDresses * 0.1;
                priceDresses -= discount;
            }

            double total = decor + priceDresses;

            if (total > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {total - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - total:f2} leva left.");
            }
        }
    }
}
