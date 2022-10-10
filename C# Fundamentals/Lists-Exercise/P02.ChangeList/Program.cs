using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Delete":
                        numbers.RemoveAll(x => x == int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        int element = int.Parse(tokens[1]);
                        int position = int.Parse(tokens[2]);
                        numbers.Insert(position, element);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
