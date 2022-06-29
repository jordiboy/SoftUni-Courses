using System;

namespace P03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double total = 0;
            double price = 0;                       

            string gameName = Console.ReadLine();

            while (gameName != "Game Time")
            {
                bool isFound = true;

                switch (gameName)
                {
                    case "OutFall 4": price = 39.99; break;
                    case "CS: OG": price = 15.99; break;
                    case "Zplinter Zell": price = 19.99; break;
                    case "Honored 2": price = 59.99; break;
                    case "RoverWatch": price = 29.99; break;
                    case "RoverWatch Origins Edition": price = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        isFound = false;
                        break;
                }

                if (price > budget - total)
                {
                    Console.WriteLine("Too Expensive");
                }                
                else if (isFound == true)
                {
                    total += price;
                    Console.WriteLine($"Bought {gameName}");
                }

                gameName = Console.ReadLine();

                if (budget - total == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }

            Console.WriteLine($"Total spent: ${total:f2}. Remaining: ${budget - total:f2}");
        }
    }
}
