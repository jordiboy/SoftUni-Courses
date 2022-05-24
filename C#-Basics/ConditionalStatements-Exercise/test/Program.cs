using System;
namespace Lunch_Brake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTvSeries = Console.ReadLine();
            int seriesLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());

            double lunchTime = (double)breakLenght / 8;
            int breakTime = breakLenght / 4;

            double timeNeeded = seriesLenght + (double)lunchTime + breakTime;
            if (breakLenght >= timeNeeded)
            {
                double timeLeftToWatch = Math.Ceiling(breakLenght - lunchTime - breakTime - seriesLenght);
                Console.WriteLine($"You have enough time to watch {nameOfTvSeries} and left with {timeLeftToWatch:f0} minutes free time.");
            }
            else 
            {
                double timeNeededToWatch = Math.Ceiling(timeNeeded - breakLenght);
                Console.WriteLine($"You don't have enough time to watch {nameOfTvSeries}, you need {timeNeededToWatch:f0} more minutes.");
            }
        }
    }
}
