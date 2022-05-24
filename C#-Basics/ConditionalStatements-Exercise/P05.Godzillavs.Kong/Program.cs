using System;

namespace P05.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double dressPrice = double.Parse(Console.ReadLine());

            double dresses = countStatists * dressPrice;
            double decor = budget * 0.1;

            if (countStatists >= 150)
            {
                double discount = dresses * 0.1;
                dresses -= discount;
            }

            double totalExpense = decor + dresses;

            if (totalExpense > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalExpense - budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalExpense:f2} leva left.");
            }
        }
    }
}
