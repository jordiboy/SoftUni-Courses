using System;

namespace P06._EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBreads = int.Parse(Console.ReadLine());

            int bestPoints = 0;
            string bestBaker = string.Empty;

            for (int i = 1; i <= countBreads; i++)
            {
                string baker = Console.ReadLine();
                string input = Console.ReadLine();

                int points = 0;

                while (input != "Stop")
                {
                    int rating = int.Parse(input);

                    points += rating;

                    input = Console.ReadLine();
                }

                Console.WriteLine($"{baker} has {points} points.");

                if (bestPoints < points)
                {
                    bestPoints = points;
                    bestBaker = baker;
                    Console.WriteLine($"{bestBaker} is the new number 1!");
                }

            }

            Console.WriteLine($"{bestBaker} won competition with {bestPoints} points!");
        }
    }
}
