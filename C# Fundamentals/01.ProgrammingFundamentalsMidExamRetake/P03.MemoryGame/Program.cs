using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = Console.ReadLine();
            int turn = 0;

            while (command != "end")
            {
                int[] indexes = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                turn++;

                if (elements.Count > 0)
                {
                    if (indexes[0] == indexes[1] || indexes[0] > elements.Count - 1
                    || indexes[1] > elements.Count - 1 || indexes[0] < 0 || indexes[1] < 0)
                    {
                        int middle = elements.Count / 2;
                        elements.Insert(middle, $"{-turn}a");
                        elements.Insert(middle, $"{-turn}a");
                        Console.WriteLine("Invalid input! Adding additional elements to the board");
                    }
                    else
                    {
                        if (elements[indexes[0]] == elements[indexes[1]])
                        {

                            Console.WriteLine($"Congrats! You have found matching elements - {elements[indexes[0]]}!");
                            int index1 = indexes[0];
                            RemoveElements(elements, index1);                            
                        }
                        else if (elements[indexes[0]] != elements[indexes[1]])
                        {
                            Console.WriteLine("Try again!");
                        }

                        if (elements.Count == 0)
                        {
                            Console.WriteLine($"You have won in {turn} turns!");
                        }
                    }
                } 

                command = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
        public static void RemoveElements(List<string> elements, int index1)
        {
            string remove = elements[index1];
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == remove)
                {
                    elements.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
