using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var plants = new Dictionary<string, double[]>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = input[0];
                int rarity = int.Parse(input[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new double[2]);
                    plants[plant][0] = rarity;
                }
                else
                {
                    plants[plant][0] = rarity;
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] commandArgs = Regex.Split(command, @" - | ");
                string action = commandArgs[0];
                string plant = commandArgs[1];

                if (action == "Rate:")
                {
                    if (plants.ContainsKey(plant))
                    {
                        double rating = double.Parse(commandArgs[2]);
                        if (plants[plant][1] > 0)
                        {
                            plants[plant][1] = (plants[plant][1] + rating) / 2;
                        }
                        else
                        {
                            plants[plant][1] = rating;
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "Update:")
                {
                    if (plants.ContainsKey(plant))
                    {
                        double rarity = double.Parse(commandArgs[2]);
                        plants[plant][0] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "Reset:")
                {
                    if (plants.ContainsKey(plant))
                    {
                        plants[plant][1] = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }
        }
    }
}
