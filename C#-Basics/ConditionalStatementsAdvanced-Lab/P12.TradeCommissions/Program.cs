using System;

namespace P12.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double commision = 0;

            if (sells <= 500)
            {
                switch (town)
                {
                    case "Sofia":
                        commision = 0.05;
                        break;
                    case "Varna":
                        commision = 0.045;
                        break;
                    case "Plovdiv":
                        commision = 0.055;
                        break;                    
                }
            }
            else if (sells <= 1000)
            {
                switch (town)
                {
                    case "Sofia":
                        commision = 0.07;
                        break;
                    case "Varna":
                        commision = 0.075;
                        break;
                    case "Plovdiv":
                        commision = 0.08;
                        break;                    
                }
            }
            else if (sells <= 10000)
            {
                switch (town)
                {
                    case "Sofia":
                        commision = 0.08;
                        break;
                    case "Varna":
                        commision = 0.1;
                        break;
                    case "Plovdiv":
                        commision = 0.12;
                        break;                    
                }
            }
            else
            {
                switch (town)
                {
                    case "Sofia":
                        commision = 0.12;
                        break;
                    case "Varna":
                        commision = 0.13;
                        break;
                    case "Plovdiv":
                        commision = 0.145;
                        break;                   
                }
            }

            double totalCommision = sells * commision;

            if (totalCommision > 0)
            {
                Console.WriteLine($"{totalCommision:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
