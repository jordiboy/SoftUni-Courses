using System;

namespace P04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededProfit = double.Parse(Console.ReadLine());

            double total = 0;

            string cocktailName = Console.ReadLine();

            while (cocktailName != "Party!")
            {
                int countCocktails = int.Parse(Console.ReadLine());

                double price = cocktailName.Length;

                price *= countCocktails;

                if (price % 2 != 0)
                {
                    double discount = price * 0.25;
                    price -= discount;
                }

                total += price;

                if (total >= neededProfit)
                {
                    break;
                }

                cocktailName = Console.ReadLine();
            }

            if (total < neededProfit)
            {
                Console.WriteLine($"We need {neededProfit - total:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
            }
            Console.WriteLine($"Club income - {total:f2} leva.");
        }
    }
}
