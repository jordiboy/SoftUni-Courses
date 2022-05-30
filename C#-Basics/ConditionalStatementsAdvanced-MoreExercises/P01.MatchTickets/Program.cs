using System;

namespace P01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int countPeople = int.Parse(Console.ReadLine());

            double transport;
            double ticketPrice;

            if (countPeople < 5)
            {
                transport = budget * 0.75;
            }
            else if (countPeople < 10)
            {
                transport = budget * 0.6;
            }
            else if (countPeople < 25)
            {
                transport = budget * 0.5;
            }
            else if (countPeople < 50)
            {
                transport = budget * 0.4;
            }
            else
            {
                transport = budget * 0.25;
            }
            switch (category)
            {
                case "VIP":
                    ticketPrice = countPeople * 499.99;
                        break;
                default:
                    ticketPrice = countPeople * 249.99;
                    break;
            }

            double total = transport + ticketPrice;

            if (budget >= total)
            {
                Console.WriteLine($"Yes! You have {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total - budget:f2} leva.");
            }
        }
    }
}
