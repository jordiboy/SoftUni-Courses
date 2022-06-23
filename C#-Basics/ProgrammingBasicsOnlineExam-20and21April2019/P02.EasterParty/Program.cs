using System;

namespace P02.EasterParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            double guestPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double discount = 0;

            if (countGuests >= 10 && countGuests <= 15)
            {
                discount = guestPrice * 0.15;
            }
            else if (countGuests > 15 && countGuests <= 20)
            {
                discount = guestPrice * 0.2;
            }
            else if (countGuests > 20)
            {
                discount = guestPrice * 0.25;
            }

            double guests = (guestPrice - discount) * countGuests;
            double cake = budget * 0.1;

            double total = guests + cake;

            if (total <= budget)
            {
                Console.WriteLine($"It is party time! {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {total - budget:f2} leva needed.");
            }
        }
    }
}
