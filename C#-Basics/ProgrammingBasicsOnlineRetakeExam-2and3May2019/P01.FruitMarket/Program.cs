using System;

namespace P01.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberryes = double.Parse(Console.ReadLine());
            double countBananas = double.Parse(Console.ReadLine());
            double countOranges = double.Parse(Console.ReadLine());
            double countRaspberryes = double.Parse(Console.ReadLine());
            double countStrawberryes = double.Parse(Console.ReadLine());

            double priceRaspberryes = priceStrawberryes - (priceStrawberryes * 0.5);
            double priceOranges = priceRaspberryes - (priceRaspberryes * 0.4);
            double priceBananas = priceRaspberryes - (priceRaspberryes * 0.8);

            double strawberryes = priceStrawberryes * countStrawberryes;
            double raspberyes = priceRaspberryes * countRaspberryes;
            double oranges = priceOranges * countOranges;
            double bananas = priceBananas * countBananas;

            double sum = strawberryes + raspberyes + oranges + bananas;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
