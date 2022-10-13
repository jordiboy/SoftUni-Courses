using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] command = input.Split().ToArray();

                if (command[0] == "Shoot")
                {                    
                    int index = int.Parse(command[1]);
                    int power = int.Parse(command[2]);

                    if (index > -1 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }                    
                    
                }
                else if (command[0] == "Add")
                {
                    int index = int.Parse(command[1]);
                    int value = int.Parse(command[2]);

                    if (index > -1 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command[0] == "Strike")
                {
                    int index = int.Parse(command[1]);
                    int radius = int.Parse(command[2]);

                    if (index + radius < targets.Count && index - radius > -1)
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }                

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
