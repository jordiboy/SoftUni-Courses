using System;

namespace P06.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMagnolias = int.Parse(Console.ReadLine());
            int countHyacinths = int.Parse(Console.ReadLine());
            int countRoses = int.Parse(Console.ReadLine());
            int countCactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double magnolias = countMagnolias * 3.25;
            double hyacinths = countHyacinths * 4.0;
            double roses = countRoses * 3.5;
            double cactuses = countCactuses * 8.0;

            double sum = magnolias + hyacinths + roses + cactuses;
            double tax = sum * 0.05;

            sum -= tax;

            if (sum >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(sum - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - sum)} leva.");
            }
                        
        }
    }
}
