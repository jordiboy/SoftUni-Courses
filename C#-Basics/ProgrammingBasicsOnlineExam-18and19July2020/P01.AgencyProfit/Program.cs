using System;

namespace P01.AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double priceAdultTicket = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double priceAdults = (priceAdultTicket + tax) * adultTickets;
            double priceKids = priceAdultTicket - (priceAdultTicket * 0.7);
            priceKids = (priceKids + tax) * kidTickets;

            double total = priceAdults + priceKids;
            double agencyShare = total * 0.2;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {agencyShare:f2} lv.");
        }
    }
}
