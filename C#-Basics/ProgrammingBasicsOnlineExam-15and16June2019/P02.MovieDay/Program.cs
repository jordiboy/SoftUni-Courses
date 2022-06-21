using System;

namespace P02.MovieDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForFilming = int.Parse(Console.ReadLine());
            int countScenes = int.Parse(Console.ReadLine());
            int timeForScene = int.Parse(Console.ReadLine());

            double terrain = timeForFilming * 0.15;
            timeForScene *= countScenes;

            double totalTime = timeForScene + terrain;

            if (timeForFilming >= totalTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForFilming - totalTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(totalTime - timeForFilming)} minutes.");
            }
        }
    }
}
