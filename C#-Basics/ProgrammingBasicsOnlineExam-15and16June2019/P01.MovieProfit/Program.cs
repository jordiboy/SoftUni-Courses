using System;

namespace P01.MovieProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());
            int countTickets = int.Parse(Console.ReadLine());
            double priceTicket = double.Parse(Console.ReadLine());
            int percentForCinema = int.Parse(Console.ReadLine());

            priceTicket *= countTickets;
            priceTicket *= countDays;

            double taxForCinema = priceTicket * percentForCinema / 100;

            double total = priceTicket - taxForCinema;

            Console.WriteLine($"The profit from the movie {movieName} is {total:f2} lv.");
        }
    }
}
