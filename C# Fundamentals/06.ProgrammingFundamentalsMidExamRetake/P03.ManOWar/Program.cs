using System;
using System.Linq;

namespace P03.ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] warShip = Console.ReadLine()
                .Split(">", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int maxHealth = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] commandArgs = command
                    .Split(" ");

                string action = commandArgs[0];

                if (action == "Fire")
                {
                    int index = int.Parse(commandArgs[1]);
                    int damage = int.Parse(commandArgs[2]);

                    if (IsIndexValid(warShip, index))
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }                    
                }
                else if (action == "Defend")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int damage = int.Parse(commandArgs[3]);

                    if (IsIndexValid(pirateShip, startIndex) && IsIndexValid(pirateShip, endIndex))
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (action == "Repair")
                {
                    int index = int.Parse(commandArgs[1]);
                    int health = int.Parse(commandArgs[2]);

                    if (IsIndexValid(pirateShip, index))
                    {
                        if (pirateShip[index] + health >= maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                        else
                        {
                            pirateShip[index] += health;
                        }
                    }
                }
                else if (action == "Status")
                {
                    int count = 0;

                    for (int i = 0; i < pirateShip.Length; i++)
                    {
                        double percent = (pirateShip[i] / (double)maxHealth) * 100;

                        if (percent < 20)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"{count} sections need repair.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
        public static bool IsIndexValid(int[] ship, int index)
        {
            bool isValid = false;
            if (index > -1 && index < ship.Length)
            {
                isValid = true;
                return isValid;
            }

            return isValid;
        }
    }
    
}
