using System;

namespace P05.TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTurnirs = int.Parse(Console.ReadLine());
            int entryPoints = int.Parse(Console.ReadLine());

            int totalPoints = entryPoints;
            int countWins = 0;

            for (int i = 1; i <= countTurnirs; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W":
                        countWins++;
                        totalPoints += 2000;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;
                }
            }

            int averagePoints = (totalPoints - entryPoints) / countTurnirs;
            double percentWins = (countWins / (double)countTurnirs) * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentWins:f2}%");
        }
    }
}
