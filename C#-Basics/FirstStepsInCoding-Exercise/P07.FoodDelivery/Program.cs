using System;

namespace P07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countChicken = int.Parse(Console.ReadLine());
            int countCFish = int.Parse(Console.ReadLine());
            int countVegetarian = int.Parse(Console.ReadLine());

            double chicken = countChicken * 10.35;
            double fish = countCFish * 12.40;
            double vegetarian = countVegetarian * 8.15;
            double sum = chicken + fish + vegetarian;
            double desert = sum * 0.20;
            sum += desert + 2.50;
            Console.WriteLine(sum);

        }
    }
}
