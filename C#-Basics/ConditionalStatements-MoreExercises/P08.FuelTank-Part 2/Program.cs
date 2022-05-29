using System;

namespace P08.FuelTank_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double liters = double.Parse(Console.ReadLine());
            string card = Console.ReadLine().ToLower();

            double cardDiscount = 0;
            double total = 0;
            double discount = 0;

            if (card == "yes")
            {
                switch (fuel)
                {
                    case "gasoline":
                        cardDiscount = liters * 0.18;
                        break;
                    case "diesel":
                        cardDiscount = liters * 0.12;
                        break;
                    case "gas":
                        cardDiscount = liters * 0.08;
                        break;                    
                }
            }
            if (fuel == "gasoline")
            {
                total = liters * 2.22 - cardDiscount;
            }
            else if (fuel == "diesel")
            {
                total = liters * 2.33 - cardDiscount;
            }
            else if (fuel == "gas")
            {
                total = liters * 0.93 - cardDiscount;
            }
            if (liters >= 20 && liters <= 25)
            {
                discount = total * 0.08;
            }
            else if (liters > 25)
            {
                discount = total * 0.1;
            }

            total -= discount;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
