using System;

namespace P01.EasterBakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceFlour = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int eggsPackage = int.Parse(Console.ReadLine());
            int yeastPackage = int.Parse(Console.ReadLine());

            double flour = priceFlour * kgFlour;
            double sugarPrice = priceFlour * 0.75;
            double sugar = sugarPrice * kgSugar;
            double eggs = eggsPackage * (priceFlour * 1.1);
            double yeast = yeastPackage * (sugarPrice * 0.2);

            double total = flour + sugar + eggs + yeast;

            Console.WriteLine($"{total:f2}");
        }
    }
}
