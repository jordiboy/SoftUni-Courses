using System;

namespace P03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string package = Console.ReadLine();
            int countTickets = int.Parse(Console.ReadLine());

            double price = 0;

            if (movieName == "John Wick")
            {
                switch (package)
                {
                    case "Drink": price = 12; break;
                    case "Popcorn": price = 15; break;
                    case "Menu": price = 19; break;
                }
            }
            else if (movieName == "Star Wars")
            {
                switch (package)
                {
                    case "Drink": price = 18; break;
                    case "Popcorn": price = 25; break;
                    case "Menu": price = 30; break;
                }
            }
            else if (movieName == "Jumanji")
            {
                switch (package)
                {
                    case "Drink": price = 9; break;
                    case "Popcorn": price = 11; break;
                    case "Menu": price = 14; break;
                }
            }

            double total = price * countTickets;

            if (movieName == "Star Wars" && countTickets >= 4)
            {
                double discount = total * 0.3;
                total -= discount;
            }

            if (movieName == "Jumanji" && countTickets == 2)
            {
                double discount = total * 0.15;
                total -= discount;
            }

            Console.WriteLine($"Your bill is {total:f2} leva.");
        }
    }
}
