using System;

namespace P05.PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] products = new double[4];

            for (int i = 1; i <= n; i++)
            {
                string gameName = Console.ReadLine();

                switch (gameName)
                {
                    case "Hearthstone": products[0]++; break;
                    case "Fornite": products[1]++; break;
                    case "Overwatch": products[2]++; break;
                    default: products[3]++; break;
                }

            }

            Console.WriteLine($"Hearthstone - {(products[0] / n) * 100:f2}%");
            Console.WriteLine($"Fornite - {(products[1] / n) * 100:f2}%");
            Console.WriteLine($"Overwatch - {(products[2] / n) * 100:f2}%");
            Console.WriteLine($"Others - {(products[3] / n) * 100:f2}%");
        }
    }
}
