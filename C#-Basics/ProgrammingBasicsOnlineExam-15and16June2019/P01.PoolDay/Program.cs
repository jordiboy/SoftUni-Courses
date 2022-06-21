using System;

namespace P01.SeriesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int countSeasons = int.Parse(Console.ReadLine());
            int countEpisodes = int.Parse(Console.ReadLine());
            double episodeTime = double.Parse(Console.ReadLine());

            double advertise = episodeTime * 0.2;
            double special = countSeasons * 10;
            episodeTime += advertise;

            double totalMinutes = Math.Round((countSeasons * (countEpisodes * episodeTime)) + special);

            Console.WriteLine($"Total time needed to watch the {movieName} series is {totalMinutes} minutes.");
        }
    }
}
