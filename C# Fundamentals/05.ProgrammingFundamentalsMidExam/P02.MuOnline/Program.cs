using System;
using System.Collections.Generic;

namespace P02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            int health = 100;
            int bitcoins = 0;
            int bestRoom = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int room = i + 1;

                string[] actions = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = actions[0];

                if (action == "potion")
                {
                    int potion = int.Parse(actions[1]);
                    if (health + potion > 100)
                    {                        
                        potion = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        health += potion;
                    }

                    Console.WriteLine($"You healed for {potion} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (action == "chest")
                {
                    int coins = int.Parse(actions[1]);
                    bitcoins += coins;

                    Console.WriteLine($"You found {coins} bitcoins.");
                }
                else
                {
                    int attack = int.Parse(actions[1]);

                    health -= attack;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {action}.");
                        Console.WriteLine($"Best room: {room}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {action}.");
                    }
                }

                bestRoom = room;
            }

            if (bestRoom == input.Length)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
