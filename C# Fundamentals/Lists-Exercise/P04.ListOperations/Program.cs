using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.ListOperations
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

                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    numbers.Add(int.Parse(tokens[1]));
                }
                else if (tokens[0] == "Insert")
                {
                    int index = int.Parse(tokens[2]);
                    int element = int.Parse(tokens[1]);
                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, element);
                    }
                }
                else if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    
                    if (index > numbers.Count || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (tokens[0] == "Shift")
                {
                    int count = int.Parse(tokens[2]);

                    if (tokens[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int toAdd = numbers[0];
                            numbers.Add(toAdd);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (tokens[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int toInsert = numbers[numbers.Count - 1];
                            numbers.Insert(0, toInsert);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
