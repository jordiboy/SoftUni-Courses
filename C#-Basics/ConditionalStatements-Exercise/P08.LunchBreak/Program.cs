using System;

namespace P08.LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int movieTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * (1.0 / 8);
            double restTime = breakTime * (1.0 / 4);
            double freetime = breakTime - lunchTime - restTime;
            
            if (freetime >= movieTime)
            {                
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(freetime - movieTime)} minutes free time.");
            }
            else
            {                               
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(movieTime - freetime)} more minutes.");                
            }
        }
    }
}
