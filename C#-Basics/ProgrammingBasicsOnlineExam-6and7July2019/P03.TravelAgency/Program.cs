using System;

namespace P03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            string package = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double discount = 0;
            double price = 0;

            if (days > 7)
            {
                days--;
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            
            if (townName == "Bansko" || townName == "Borovets")
            {
                if (package == "withEquipment")
                {
                    price = 100;

                    if (vip == "yes")
                    {
                        discount = price * 0.1;
                        price -= discount;
                    }                    
                }
                else if (package == "noEquipment")
                {
                    price = 80;

                    if (vip == "yes")
                    {
                        discount = price * 0.05;
                        price -= discount;
                    }                    
                }

            }
            if (townName == "Varna" || townName == "Burgas")
            {
                if (package == "withBreakfast")
                {
                    price = 130;

                    if (vip == "yes")
                    {
                        discount = price * 0.12;
                        price -= discount;
                    }
                }
                else if (package == "noBreakfast")
                {
                    price = 100;

                    if (vip == "yes")
                    {
                        discount = price * 0.07;
                        price -= discount;
                    }
                }
            }

            double total = price * days;

            if (total > 0)
            {
                Console.WriteLine($"The price is {total:f2}lv! Have a nice time!");
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
