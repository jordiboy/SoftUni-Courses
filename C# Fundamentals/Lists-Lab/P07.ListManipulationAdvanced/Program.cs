using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            bool isChanged = false;

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
                    case "Add":
                        numbers.Add(int.Parse(tokens[1])); isChanged = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(tokens[1])); isChanged = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(tokens[1])); isChanged = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(tokens[2]), int.Parse(tokens[1])); isChanged = true;
                        break;
                    case "Contains":                         
                        if (numbers.Contains(int.Parse(tokens[1])))
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ",numbers.FindAll(x => x % 2 == 0))); 
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.FindAll(x => x % 2 != 0))); 
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":

                        switch (tokens[1])
                        {
                            case "<": Console.WriteLine(string.Join(" ",
                                numbers.FindAll(x => x < int.Parse(tokens[2])))); break;
                            case ">": Console.WriteLine(string.Join(" ",
                                numbers.FindAll(x => x > int.Parse(tokens[2])))); break;
                            case "<=": Console.WriteLine(string.Join(" ",
                                numbers.FindAll(x => x <= int.Parse(tokens[2])))); break;
                            case ">=": Console.WriteLine(string.Join(" ",
                                numbers.FindAll(x => x >= int.Parse(tokens[2])))); break;
                        }
                        break;
                }                
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }        
    }
}
