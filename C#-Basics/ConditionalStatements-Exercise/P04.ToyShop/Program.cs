using System;

namespace P04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursion = double.Parse(Console.ReadLine());
            int countPuzzles = int.Parse(Console.ReadLine());
            int countDolls = int.Parse(Console.ReadLine());
            int countBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTrucks = int.Parse(Console.ReadLine());

            double puzzles = countPuzzles * 2.6;
            double dolls = countDolls * 3;
            double bears = countBears * 4.1;
            double minions = countMinions * 8.2;
            double trucks = countTrucks * 2;
            double sum = puzzles + dolls + bears + minions + trucks;
            int countToys = countPuzzles + countDolls + countBears + countMinions + countTrucks;

            if (countToys >= 50)
            {
                double discount = sum * 0.25;
                sum -= discount;
            }

            double rent = sum * 0.10;
            sum -= rent;

            if (sum >= excursion)
            {
                Console.WriteLine($"Yes! {sum - excursion:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursion - sum:f2} lv needed.");
            }
        }
    }
}
