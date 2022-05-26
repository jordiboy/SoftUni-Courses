using System;

namespace P09.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0;

            days--;     // Nights, Example: 11 days - 1 = 10 nights

            if (days < 10)
            {
                switch (room)
                {
                    case "apartment":
                        price = days * 25.0;
                        double discount = price * 0.30;
                        price -= discount;
                        break;
                    case "president apartment":
                        price = days * 35.0;
                        discount = price * 0.10;
                        price -= discount;
                        break;
                }
            }
            else if (days <= 15)
            {
                switch (room)
                {
                    case "apartment":
                        price = days * 25.0;
                        double discount = price * 0.35;
                        price -= discount;
                        break;
                    case "president apartment":
                        price = days * 35.0;
                        discount = price * 0.15;
                        price -= discount;
                        break;                    
                }
            }
            else
            {
                switch (room)
                {
                    case "apartment":
                        price = days * 25.0;
                        double discount = price * 0.50;
                        price -= discount;
                        break;
                    case "president apartment":
                        price = days * 35.0;
                        discount = price * 0.20;
                        price -= discount;
                        break;                    
                }
            }
            if (room == "room for one person")
            {
                price = days * 18.0;
            }
            if (rating == "positive")
            {
                double discount = price * 0.25;
                price += discount;
            }
            else
            {
                double discount = price * 0.1;
                price -= discount;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
