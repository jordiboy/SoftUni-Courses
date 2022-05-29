using System;

namespace P04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double price = 0;

            if (distance < 20)
            {
                price = 0.7;

                switch (dayOrNight)
                {
                    case "night":
                        price += distance * 0.9; 
                        break;
                    default:
                        price += distance * 0.79;
                        break;
                }
            }
            else if (distance < 100)
            {
                price = distance * 0.09;
            }
            else
            {
                price = distance * 0.06;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
