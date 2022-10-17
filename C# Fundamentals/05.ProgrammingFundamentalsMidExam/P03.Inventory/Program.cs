using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                string[] commandArgs = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commandArgs[0];
                string item = commandArgs[1];

                if (items.Contains(item))
                {
                    if (command == "Drop")
                    {
                        items.Remove(item);
                    }
                    else if (command == "Renew")
                    {
                        items.Remove(item);
                        items.Add(item);
                    }                                       
                }

                if (command == "Combine Items")
                {
                    string[] combine = item
                        .Split(":");

                    string oldItem = combine[0];
                    string newItem = combine[1];

                    if (items.Contains(oldItem))
                    {
                        int index = items.IndexOf(oldItem);
                        items.Insert(index + 1, newItem);
                    }                    
                }

                if (command == "Collect" && !items.Contains(item))
                {
                    items.Add(item);
                }                

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
