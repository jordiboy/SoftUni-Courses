using System;

namespace P05.EasterBake
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBreads = int.Parse(Console.ReadLine());

            double maxSugar = 0;
            double maxFlour = 0;
            double totalSugar = 0;
            double totalFlour = 0;

            for (int i = 1; i <= countBreads; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());

                if (maxSugar < sugar)
                {
                    maxSugar = sugar;
                }
                if (maxFlour < flour)
                {
                    maxFlour = flour;
                }

                totalSugar += sugar;
                totalFlour += flour;
            }

            double sugarPackages = totalSugar / 950;
            double flourPackages = totalFlour / 750;

            Console.WriteLine($"Sugar: {Math.Ceiling(sugarPackages)}");
            Console.WriteLine($"Flour: {Math.Ceiling(flourPackages)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
