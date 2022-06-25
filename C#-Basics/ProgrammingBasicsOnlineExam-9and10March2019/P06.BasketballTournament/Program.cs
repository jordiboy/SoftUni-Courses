using System;

namespace P06.BasketballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string tournament = Console.ReadLine();

            double totalMatches = 0;
            double wins = 0;
            double loses = 0;

            while (tournament != "End of tournaments")
            {
                int countMatch = int.Parse(Console.ReadLine());                

                for (int i = 1; i <= countMatch; i++)
                {
                    int points1 = int.Parse(Console.ReadLine());
                    int points2 = int.Parse(Console.ReadLine());
                    int pointsDiff = 0;

                    totalMatches++;

                    if (points1 > points2)
                    {
                        wins++;
                        pointsDiff = points1 - points2;
                    }
                    else
                    {
                        loses++;
                        pointsDiff = points2 - points1;
                    }

                    if (points1 > points2)
                    {
                        Console.WriteLine($"Game {i} of tournament {tournament}: win with {pointsDiff} points.");
                    }
                    else
                    {
                        Console.WriteLine($"Game {i} of tournament {tournament}: lost with {pointsDiff} points.");
                    }
                    
                }

                tournament = Console.ReadLine();
            }

            Console.WriteLine($"{(wins / totalMatches) * 100:f2}% matches win");
            Console.WriteLine($"{(loses / totalMatches) * 100:f2}% matches lost");
        }
    }
}
