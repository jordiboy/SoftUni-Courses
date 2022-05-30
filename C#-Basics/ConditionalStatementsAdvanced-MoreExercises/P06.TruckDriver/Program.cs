using System;

namespace P06.TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());

            double pricePerKm = 0;

            if (kilometers < 5001)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.75;
                        break;
                    case "Summer":
                        pricePerKm = 0.9;
                        break;
                    case "Winter":
                        pricePerKm = 1.05;
                        break;
                }
            }
            else if (kilometers < 10001)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.95;
                        break;
                    case "Summer":
                        pricePerKm = 1.1;
                        break;
                    case "Winter":
                        pricePerKm = 1.25;
                        break;
                }
            }
            else if (kilometers < 20001)
            {
                pricePerKm = 1.45;
            }

            double total = (kilometers * pricePerKm) * 4;
            double tax = total * 0.1;
            total -= tax;

            Console.WriteLine($"{total:f2}");
        }
    }
}
