using System;

namespace P03.CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string shugar = Console.ReadLine();
            int countDrinks = int.Parse(Console.ReadLine());

            double price = 0;

            if (drink == "Espresso")
            {
                switch (shugar)
                {
                    case "Without": price = 0.9; break;
                    case "Normal": price = 1; break;
                    case "Extra": price = 1.2; break;                    
                }
            }
            else if (drink == "Cappuccino")
            {
                switch (shugar)
                {
                    case "Without": price = 1; break;
                    case "Normal": price = 1.2; break;
                    case "Extra": price = 1.6; break;
                }
            }
            else if (drink == "Tea")
            {
                switch (shugar)
                {
                    case "Without": price = 0.5; break;
                    case "Normal": price = 0.6; break;
                    case "Extra": price = 0.7; break;
                }
            }

            price *= countDrinks;

            if (shugar == "Without")
            {
                double discount = price * 0.35;
                price -= discount;
            }
            if (drink == "Espresso" && countDrinks >= 5)
            {
                double discount = price * 0.25;
                price -= discount;
            }
            if (price > 15)
            {
                double discount = price * 0.2;
                price -= discount;
            }

            Console.WriteLine($"You bought {countDrinks} cups of {drink} for {price:f2} lv.");
        }
    }
}
