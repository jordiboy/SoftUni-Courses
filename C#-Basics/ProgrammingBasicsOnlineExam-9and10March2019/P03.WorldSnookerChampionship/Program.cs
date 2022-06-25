using System;

namespace P03.WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string typeTicket = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());
            char trophyPic = char.Parse(Console.ReadLine());

            double priceTicket = 0;
            bool isPic = false;

            if (stage == "Quarter final")
            {
                switch (typeTicket)
                {
                    case "Standard": priceTicket = 55.5; break;
                    case "Premium": priceTicket = 105.2; break;
                    case "VIP": priceTicket = 118.9; break;
                }
            }
            else if (stage == "Semi final")
            {
                switch (typeTicket)
                {
                    case "Standard": priceTicket = 75.88; break;
                    case "Premium": priceTicket = 125.22; break;
                    case "VIP": priceTicket = 300.4; break;
                }
            }
            else if (stage == "Final")
            {
                switch (typeTicket)
                {
                    case "Standard": priceTicket = 110.1; break;
                    case "Premium": priceTicket = 160.66; break;
                    case "VIP": priceTicket = 400; break;
                }
            }

            double total = countTickets * priceTicket;

            if (total > 4000)
            {
                total -= total * 0.25;
                isPic = true;
            }
            else if (total > 2500)
            {
                total -= total * 0.1;
            }

            if (trophyPic == 'Y' && isPic == false)
            {
                total += countTickets * 40;
            }            

            Console.WriteLine($"{total:f2}");
        }
    }
}
