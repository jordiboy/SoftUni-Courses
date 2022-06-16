using System;

namespace P05.FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            int games = int.Parse(Console.ReadLine());

            if (games == 0)
            {
                Console.WriteLine($"{footballTeam} hasn't played any games during this season.");
                return;
            }

            double[] count = new double[3];
            int points = 0;

            for (int i = 1; i <= games; i++)
            {
                char result = char.Parse(Console.ReadLine());

                switch (result)
                {
                    case 'W': points += 3; count[0]++; break;
                    case 'D': points++; count[1]++; break;
                    case 'L': count[2]++; break;                    
                }
            }

            Console.WriteLine($"{footballTeam} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {count[0]}");
            Console.WriteLine($"## D: {count[1]}");
            Console.WriteLine($"## L: {count[2]}");
            Console.WriteLine($"Win rate: {(count[0] / games) * 100:f2}%");
        }
    }
}
