using System;

namespace P04.EasterShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEggsInStore = int.Parse(Console.ReadLine());

            int selledEggs = 0;

            string input = Console.ReadLine();

            while (input != "Close")
            {
                int countEggs = int.Parse(Console.ReadLine());

                if (input == "Buy")
                {
                    if (countEggs > countEggsInStore)
                    {
                        break;
                    }

                    selledEggs += countEggs;
                    countEggsInStore -= countEggs;
                }
                else if (input == "Fill")
                {
                    countEggsInStore += countEggs;
                }

                input = Console.ReadLine();
            }

            if (input == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{selledEggs} eggs sold.");
            }
            else
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {countEggsInStore}.");
            }
        }
    }
}
