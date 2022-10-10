using System;
using System.Collections.Generic;

namespace P03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                string guest = Console.ReadLine();

                string[] tokens = guest.Split();
                string command = string.Join(" ", tokens[1], tokens[2]);

                if (command == "is going!")
                {
                    if (guests.Contains(tokens[0]))
                    {
                        Console.WriteLine($"{tokens[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(tokens[0]);
                    }
                }
                else if (command == "is not")
                {
                    if (guests.Contains(tokens[0]))
                    {
                        guests.Remove(tokens[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{tokens[0]} is not in the list!");
                    }
                    
                }
            }
            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}
