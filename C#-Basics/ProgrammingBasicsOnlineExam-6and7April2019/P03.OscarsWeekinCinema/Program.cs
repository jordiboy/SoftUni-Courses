using System;

namespace P03.OscarsWeekinCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string hall = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());

            double priceTicket = 0;

            if (movieName == "A Star Is Born")
            {
                switch (hall)
                {
                    case "normal": priceTicket = 7.5; break;
                    case "luxury": priceTicket = 10.5; break;
                    case "ultra luxury": priceTicket = 13.5; break;
                    
                }
            }
            if (movieName == "Bohemian Rhapsody")
            {
                switch (hall)
                {
                    case "normal": priceTicket = 7.35; break;
                    case "luxury": priceTicket = 9.45; break;
                    case "ultra luxury": priceTicket = 12.75; break;

                }
            }
            if (movieName == "Green Book")
            {
                switch (hall)
                {
                    case "normal": priceTicket = 8.15; break;
                    case "luxury": priceTicket = 10.25; break;
                    case "ultra luxury": priceTicket = 13.25; break;

                }
            }
            if (movieName == "The Favourite")
            {
                switch (hall)
                {
                    case "normal": priceTicket = 8.75; break;
                    case "luxury": priceTicket = 11.55; break;
                    case "ultra luxury": priceTicket = 13.95; break;

                }
            }

            double total = countTickets * priceTicket;

            Console.WriteLine($"{movieName} -> {total:f2} lv.");
        }
    }
}
