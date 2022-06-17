using System;

namespace P04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string product = Console.ReadLine();
            int counter = 0;
            double total = 0;            

            while (product != "Stop")
            {
                double price = double.Parse(Console.ReadLine());

                counter++;

                if (counter % 3 == 0)
                {
                    price /= 2;
                }

                if (price > budget - total)
                {                    
                    total += price;
                    break;
                }

                total += price;                

                product = Console.ReadLine();
            }

            if (total <= budget)
            {
                Console.WriteLine($"You bought {counter} products for {total:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {total - budget:f2} leva!");
            }
        }
    }
}
