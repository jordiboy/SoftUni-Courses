using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine()
                .Split("|")
                .ToList();

            string command = Console.ReadLine();                

            while (command != "Yohoho!")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Loot")
                {
                    for (int i = 1; i < commandArgs.Length; i++)
                    {
                        if (!initialLoot.Contains(commandArgs[i]))
                        {
                            initialLoot.Insert(0, commandArgs[i]);
                        }
                    }
                }
                else if (commandArgs[0] == "Drop")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index > -1 && index < initialLoot.Count)
                    {
                        initialLoot.Add(initialLoot[index]);
                        initialLoot.RemoveAt(index);
                    }
                }
                else if (commandArgs[0] == "Steal")
                {
                    int count = int.Parse(commandArgs[1]);

                    if (count > initialLoot.Count)
                    {                        
                        Console.WriteLine(string.Join(", ", initialLoot));
                        initialLoot.Clear();
                    }
                    else
                    {
                        List<string> temp = new List<string>();

                        for (int i = initialLoot.Count - count; i < initialLoot.Count; i++) 
                        {
                            temp.Add(initialLoot[i]);
                            initialLoot.RemoveAt(i);
                            i--;
                        }

                        Console.WriteLine(string.Join(", ", temp));
                    }
                }

                command = Console.ReadLine();
            }

            double sum = 0;

            for (int i = 0; i < initialLoot.Count; i++)
            {
                string temp = initialLoot[i];
                sum += temp.Length;
            }

            double average = sum / initialLoot.Count;

            if (initialLoot.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
