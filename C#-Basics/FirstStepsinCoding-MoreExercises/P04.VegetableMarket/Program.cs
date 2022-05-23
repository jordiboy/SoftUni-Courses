using System;

namespace P04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int countVegetables = int.Parse(Console.ReadLine());
            int countFruits = int.Parse(Console.ReadLine());

            double totalVegetables = countVegetables * priceVegetables;
            double totalFruits = countFruits * priceFruits;
            double total = totalFruits + totalVegetables;

            total /= 1.94;

            Console.WriteLine($"{total:f2}");
        }
    }
}
