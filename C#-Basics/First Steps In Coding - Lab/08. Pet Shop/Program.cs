using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDogFood = int.Parse(Console.ReadLine());
            int countCatFood = int.Parse(Console.ReadLine());
            double total = (countDogFood * 2.50) + (countCatFood * 4);
            Console.WriteLine($"{total} lv.");
        }
    }
}
