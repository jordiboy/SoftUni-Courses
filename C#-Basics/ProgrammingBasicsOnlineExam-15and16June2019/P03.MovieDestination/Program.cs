using System;

namespace P03.MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());

            double price = 0;

            if (destination == "Dubai")
            {
                switch (season)
                {
                    case "Winter": price = 45000; break;
                    case "Summer": price = 40000; break;
                }
            }
            else if (destination == "Sofia")
            {
                switch (season)
                {
                    case "Winter": price = 17000; break;
                    case "Summer": price = 12500; break;
                }
            }
            else if (destination == "London")
            {
                switch (season)
                {
                    case "Winter": price = 24000; break;
                    case "Summer": price = 20250; break;
                }
            }

            double total = countDays * price;
            double discount = 0;

            if (destination == "Dubai")
            {
                discount = total * 0.3;
                total -= discount;
            }
            if (destination == "Sofia")
            {
                discount = total * 0.25;
                total += discount;
            }

            if (budget >= total)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - total:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {total - budget:f2} leva more!");
            }
        }
    }
}
