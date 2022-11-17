using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(", ")
                .ToList();

            var racers = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = string.Empty;
                int score = 0;

                foreach (var ch in input)
                {
                    if (Char.IsLetter(ch))
                    {
                        name += ch;
                    }
                    else if (Char.IsDigit(ch))
                    {
                        score += int.Parse(ch.ToString());
                    }
                }
                if (participants.Contains(name))
                {
                    if (!racers.ContainsKey(name))
                    {
                        racers.Add(name, score);
                    }
                    else
                    {
                        racers[name] += score;
                    }
                }                
                
                input = Console.ReadLine();
            }

            var orderedRacers = racers.OrderByDescending(x => x.Value);

            Console.WriteLine($"1st place: {orderedRacers.ElementAt(0).Key}");
            Console.WriteLine($"2nd place: {orderedRacers.ElementAt(1).Key}");
            Console.WriteLine($"3rd place: {orderedRacers.ElementAt(2).Key}");
        }
    }
}
