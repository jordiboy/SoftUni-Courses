using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int position = 0;
            string command = Console.ReadLine();

            while (command != "Love!")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                position += int.Parse(commandArgs[1]);

                if (position > neighborhood.Count -1)
                {
                    position = 0;
                }
                if (neighborhood[position] == 0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }
                else
                {
                    neighborhood[position] -= 2;

                    if (neighborhood[position] == 0)
                    {
                        Console.WriteLine($"Place {position} has Valentine's day.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {position}.");

            int count = neighborhood.Count(x => x > 0);
            int sum = neighborhood.Sum();

            if (sum == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {count} places.");
            }

        }
    }
}
