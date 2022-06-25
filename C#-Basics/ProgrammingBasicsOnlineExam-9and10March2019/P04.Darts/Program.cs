using System;

namespace P04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();

            int startPoints = 301;
            int countShots = 0;
            int unseccesfull = 0;

            string input = Console.ReadLine();

            while (input != "Retire")
            {
                int points = int.Parse(Console.ReadLine());

                switch (input)
                {                    
                    case "Double": points *= 2; break;
                    case "Triple": points *= 3; break;
                }

                if (startPoints >= points)
                {
                    startPoints -= points;
                    countShots++;
                }
                else
                {
                    unseccesfull++;
                }

                if (startPoints == 0)
                {
                    break;
                }

                input = Console.ReadLine();
            }

            if (startPoints == 0)
            {
                Console.WriteLine($"{playerName} won the leg with {countShots} shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} retired after {unseccesfull} unsuccessful shots.");
            }
        }
    }
}
