using System;

namespace P05.CareofPuppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            food *= 1000;
            int eatedFood = 0;

            string input = Console.ReadLine();            

            while (input != "Adopted")
            {
                int neededFood = int.Parse(input);
                eatedFood += neededFood;                               

                input = Console.ReadLine();
            }

            if (eatedFood > food)
            {
                Console.WriteLine($"Food is not enough. You need {eatedFood - food} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {food - eatedFood} grams.");
            }
        }
    }
}
