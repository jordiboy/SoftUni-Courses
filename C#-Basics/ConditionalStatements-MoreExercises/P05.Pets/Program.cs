using System;

namespace P05.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int placedFood = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine());

            dogFood *= countDays;
            catFood *= countDays;
            turtleFood *= countDays * 0.001;

            double totalFood = dogFood + catFood + turtleFood;

            if (totalFood <= placedFood)
            {
                Console.WriteLine($"{Math.Floor(placedFood - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood - placedFood)} more kilos of food are needed.");
            }
        }
    }
}
