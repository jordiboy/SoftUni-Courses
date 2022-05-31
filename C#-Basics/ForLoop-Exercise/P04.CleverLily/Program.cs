using System;

namespace P04.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double priceWashMashine = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());

            int countToys = 0;
            double moneyGift = 0;
            double moneyPer2Year = 0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 0)
                {
                    moneyPer2Year += 10.0;
                    moneyGift += moneyPer2Year - 1; 
                }
                else
                {
                    countToys++;
                }
            }

            double moneyFromToys = countToys * priceToy;
            double total = moneyGift + moneyFromToys;

            if (total >= priceWashMashine)
            {
                Console.WriteLine($"Yes! {total - priceWashMashine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceWashMashine - total:f2}");
            }
        }
    }
}
