using System;

namespace P04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFisherman = int.Parse(Console.ReadLine());

            double total = 0;

            if (countFisherman <= 6)
            {
                if (season == "Spring")
                {
                    double discount = 3000 * 0.1;
                    total = 3000 - discount;
                }
                else if (season == "Summer" || season == "Autumn")
                {
                    double discount = 4200 * 0.1;
                    total = 4200 - discount;
                }
                else if (season == "Winter")
                {
                    double discount = 2600 * 0.1;
                    total = 2600 - discount;
                }
            }
            else if (countFisherman <= 11)
            {
                if (season == "Spring")
                {
                    double discount = 3000 * 0.15;
                    total = 3000 - discount;
                }
                else if (season == "Summer" || season == "Autumn")
                {
                    double discount = 4200 * 0.15;
                    total = 4200 - discount;
                }
                else if (season == "Winter")
                {
                    double discount = 2600 * 0.15;
                    total = 2600 - discount;
                }
            }
            else if (countFisherman >= 12)
            {
                if (season == "Spring")
                {
                    double discount = 3000 * 0.25;
                    total = 3000 - discount;
                }
                else if (season == "Summer" || season == "Autumn")
                {
                    double discount = 4200 * 0.25;
                    total = 4200 - discount;
                }
                else if (season == "Winter")
                {
                    double discount = 2600 * 0.25;
                    total = 2600 - discount;
                }
            }
            if (countFisherman % 2 == 0 && season != "Autumn")
            {
                double discount = total * 0.05;
                total -= discount;
            }
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
