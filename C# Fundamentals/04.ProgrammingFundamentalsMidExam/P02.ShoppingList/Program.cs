using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string action = commandArgs[0];
                string item = commandArgs[1];

                if (shopingList.Contains(item))
                {
                    if (action == "Unnecessary")
                    {
                        shopingList.Remove(item);
                    }
                    else if (action == "Correct")
                    {
                        string newItem = commandArgs[2];
                        for (int i = 0; i < shopingList.Count; i++)
                        {
                            if (item == shopingList[i])
                            {
                                shopingList.Remove(item);
                                shopingList.Insert(i, newItem);
                            }
                        }
                    }
                    else if (action == "Rearrange")
                    {
                        shopingList.Remove(item);
                        shopingList.Add(item);
                    }
                }
                else
                {
                    if (action == "Urgent")
                    {
                        shopingList.Remove(item);
                        shopingList.Insert(0, item);
                    }
                }
                

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shopingList));
        }
    }
}
