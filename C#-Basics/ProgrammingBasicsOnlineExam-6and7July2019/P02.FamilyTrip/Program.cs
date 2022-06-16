using System;

namespace P02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percentOthers = int.Parse(Console.ReadLine());

            double discount = 0;

            if (countNights > 7)
            {
                discount = pricePerNight * 0.05;
                pricePerNight -= discount;
            }
            double others = (budget * percentOthers) / 100;
            double total = (countNights * pricePerNight) + others;

            if (total <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - total:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{total - budget:f2} leva needed.");
            }
        }
    }
}
