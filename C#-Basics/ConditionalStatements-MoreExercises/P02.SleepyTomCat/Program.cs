using System;

namespace P02.SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int countHolidays = int.Parse(Console.ReadLine());

            int workingDays = 365 - countHolidays;
            int allTimeToPlay = (workingDays * 63) + (countHolidays * 127);     // in minutes
            int restTime = Math.Abs(allTimeToPlay - 30000);
            int hours = restTime / 60;
            int minutes = restTime % 60;

            if (allTimeToPlay >= 30000)
            {                
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {             
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
