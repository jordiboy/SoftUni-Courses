using System;
using System.Collections.Generic;

namespace P04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var registered = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string action = input[0];
                string user = input[1];                

                if (action == "register")
                {
                    string license = input[2];

                    if (!registered.ContainsKey(user))
                    {
                        registered.Add(user, license);
                        Console.WriteLine($"{user} registered {license} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }
                else if (action == "unregister")
                {
                    if (!registered.ContainsKey(user))
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                    else
                    {
                        registered.Remove(user);
                        Console.WriteLine($"{ user} unregistered successfully");
                    }
                }                
            }

            foreach (var item in registered)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
