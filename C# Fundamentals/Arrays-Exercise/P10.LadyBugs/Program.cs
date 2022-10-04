using System;
using System.Linq;

namespace P10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];
            int[] bugs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < bugs.Length; i++)
            {
                if (bugs[i] > -1 && bugs[i] < field.Length)
                {
                    field[bugs[i]] = 1;
                }                
            }

            while (true)
            {
                string input = Console.ReadLine();
                string[] command = new string[3];

                if (input != "end")
                {
                    command = input.Split().ToArray();
                }
                else
                {
                    break;
                }

                int startIndex = int.Parse(command[0]);
                int flyLength = int.Parse(command[2]);

                if (startIndex > field.Length - 1 || startIndex < 0 || field[startIndex] == 0)
                {                    
                    continue;
                }
                if (flyLength < 0 && command[1] == "right")
                {
                    command[1] = "left";
                    flyLength = Math.Abs(flyLength);
                }
                else if (flyLength < 0 && command[1] == "left")
                {
                    command[1] = "right";
                    flyLength = Math.Abs(flyLength);
                }

                field[startIndex] = 0;

                if (command[1] == "right")
                {                    

                    while (startIndex + flyLength < field.Length)
                    {
                        if (field[startIndex + flyLength] == 1)
                        {
                            flyLength += flyLength;
                        }
                        else
                        {
                            break;
                        }                        
                    }
                    if (startIndex + flyLength < field.Length)
                    {                        
                        field[startIndex + flyLength] = 1;                        
                    }                    
                }
                else if (command[1] == "left")
                {
                    while (startIndex - flyLength > -1)
                    {
                        if (field[startIndex - flyLength] == 1)
                        {
                            flyLength += flyLength;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (startIndex - flyLength > -1)
                    {                        
                        field[startIndex - flyLength] = 1;                        
                    }                    
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
