using System;
using System.Collections.Generic;

namespace P02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var mining = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!mining.ContainsKey(resource))
                {
                    mining.Add(resource, quantity);
                }
                else
                {
                    mining[resource] += quantity;
                }
            }

            foreach (var item in mining)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
