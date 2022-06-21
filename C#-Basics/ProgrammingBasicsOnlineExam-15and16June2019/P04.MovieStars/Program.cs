using System;

namespace P04.MovieStars
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string actorName = Console.ReadLine();

            while (actorName != "ACTION")
            {
                if (actorName.Length > 15)
                {
                    budget -= budget * 0.2;
                }
                else
                {
                    budget -= double.Parse(Console.ReadLine());
                }

                if (budget <= 0)
                {
                    break;
                }

                actorName = Console.ReadLine();
            }

            if (budget <= 0)
            {
                Console.WriteLine($"We need {Math.Abs(budget):f2} leva for our actors.");
            }
            else
            {
                Console.WriteLine($"We are left with {budget:f2} leva.");
            }
        }
    }
}
