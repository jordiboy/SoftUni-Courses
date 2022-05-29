using System;

namespace P03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapes = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());

            grapes *= area;          
            double wine = 0.4 * grapes / 2.5;
            double winediff = Math.Abs(wine - wineNeeded);

            if (wineNeeded > wine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(winediff)} liters wine needed.");
            }
            else
            {               
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(winediff)} liters left -> {Math.Ceiling(winediff / countWorkers)} liters per person.");
            }
        }
    }
}
