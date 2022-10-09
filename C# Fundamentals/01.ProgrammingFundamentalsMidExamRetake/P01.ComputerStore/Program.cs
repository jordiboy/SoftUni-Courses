using System;

namespace P01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;
            double taxes = 0;

            while (true)
            {
                if (command == "special" || command == "regular")
                {
                    break;
                }

                double price = double.Parse(command);                

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");                    
                }
                else
                {
                    sum += price;
                    taxes += price * 0.2;
                }                

                command = Console.ReadLine();
            }

            double total = 0;

            total = sum + taxes;

            if (command == "special")
            {
                total = total - (total * 0.1);
            }

            if (total == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {total:f2}$");
            }
        }
    }
}
