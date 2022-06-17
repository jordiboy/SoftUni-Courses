using System;

namespace P03.Mobileoperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contract = Console.ReadLine();
            string typeContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int countMonts = int.Parse(Console.ReadLine());

            double price = 0;

            if (contract == "one")
            {
                switch (typeContract)
                {
                    case "Small": price = 9.98; break;
                    case "Middle": price = 18.99; break;
                    case "Large": price = 25.98; break;
                    case "ExtraLarge": price = 35.99; break;
                }
            }
            else if (contract == "two")
            {
                switch (typeContract)
                {
                    case "Small": price = 8.58; break;
                    case "Middle": price = 17.09; break;
                    case "Large": price = 23.59; break;
                    case "ExtraLarge": price = 31.79; break;
                }
            }

            if (internet == "yes")
            {
                if (price <= 10)
                {
                    price += 5.5;
                }
                else if (price <= 30)
                {
                    price += 4.35;
                }
                else if (price > 30)
                {
                    price += 3.85;
                }
            }

            double total = price * countMonts;

            if (contract == "two")
            {
                double discount = total * 0.0375;
                total -= discount;
            }

            

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
