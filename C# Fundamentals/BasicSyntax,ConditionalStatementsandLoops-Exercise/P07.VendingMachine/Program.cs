using System;

namespace P07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            string command = Console.ReadLine();

            while (command != "Start")
            {
                double coins = double.Parse(command);

                if (coins == 2)
                {
                    sum += coins;
                }
                else if (coins == 1)
                {
                    sum += coins;
                }
                else if (coins == 0.5)
                {
                    sum += coins;
                }
                else if (coins == 0.2)
                {
                    sum += coins;
                }
                else if (coins == 0.1)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine();
            }

            bool isValid = true;
            string input = Console.ReadLine();

            while (input != "End")
            {
                double price = 0;
                string product;

                product = input.ToLower();

                switch (product)
                {
                    case "nuts": price = 2; break;
                    case "water": price = 0.7; break;
                    case "crisps": price = 1.5; break;
                    case "soda": price = 0.8; break;
                    case "coke": price = 1; break;
                    default:
                        Console.WriteLine("Invalid product");
                        isValid = false;
                        break;
                }

                if (price > sum)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (isValid == true)
                {
                    Console.WriteLine($"Purchased {product}");
                    sum -= price;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
