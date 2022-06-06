using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.StreamOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> word = new List<char>();
            int[] commandCounter = new int[3];          // i0 = c, i1 = n, i2 = o 
            List<string> letter = new List<string>();

            while (input != "End")
            {
                char character = char.Parse(input);

                if (character >= 'a' && character <= 'z' || character >= 'A' && character <= 'Z')
                {
                    if (character == 'c' && commandCounter[0] == 0)
                    {
                        commandCounter[0]++;                        
                    }
                    else if (character == 'n' && commandCounter[1] == 0)
                    {
                        commandCounter[1]++;                        
                    }
                    else if (character == 'o' && commandCounter[2] == 0)
                    {
                        commandCounter[2]++;                        
                    }
                    else
                    {
                        word.Add(character);
                    }
                    
                    if (commandCounter.Sum() == 3)
                    {
                        Array.Clear(commandCounter, 0, commandCounter.Length);                                             
                        letter.Add(string.Join("", word));
                        word.Clear();                        
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", letter));
        }
    }
}
