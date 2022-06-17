using System;

namespace P02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelNeeded = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double fuelPrice = 2.1;
            double gid = 100;
            double discount = 0;

            double total = (fuelNeeded * fuelPrice) + gid;

            if (dayOfWeek == "Saturday")
            {
                discount = total * 0.1;
                total -= discount;
            }
            else if (dayOfWeek == "Sunday")
            {
                discount = total * 0.2;
                total -= discount;
            }

            if (budget >= total)
            {
                Console.WriteLine($"Safari time! Money left: {budget - total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {total - budget:f2} lv.");
            }
        }
    }
}
