using System;

namespace P03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChrysanthemums = int.Parse(Console.ReadLine());
            int countRoses = int.Parse(Console.ReadLine());
            int countTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double priceChrysantemums;
            double priceRoses;
            double priceTulips;
            double total = 0;            

            if (season == "Spring" || season == "Summer")
            {               
                priceChrysantemums = countChrysanthemums * 2;
                priceRoses = countRoses * 4.1;
                priceTulips = countTulips * 2.5;
                total = priceChrysantemums + priceRoses + priceTulips;               

            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrysantemums = countChrysanthemums * 3.75;
                priceRoses = countRoses * 4.5;
                priceTulips = countTulips * 4.15;
                total = priceChrysantemums + priceRoses + priceTulips;
            }

            double extraPrice = 0;

            if (holiday == "Y")
            {
                extraPrice = total * 0.15;
            }

            total += extraPrice;

            double discount = 0;

            if (countTulips > 7 && season == "Spring")
            {
                discount = total * 0.05;
            }
            if (countRoses >= 10 && season == "Winter")
            {
                discount = total * 0.1;
            }

            total -= discount;

            int countFlovers = countChrysanthemums + countRoses + countTulips;

            if (countFlovers > 20)
            {
                discount = total * 0.2;
                total -= discount;
            }

            total += 2;

            Console.WriteLine($"{total:f2}");
        }
    }
}
