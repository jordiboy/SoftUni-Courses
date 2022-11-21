using System;
using System.Collections.Generic;

namespace P03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var pieces = new Dictionary<string, string[]>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = commands[0];
                string composer = commands[1];
                string key = commands[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces.Add(piece, new string[2]);
                    pieces[piece][0] = composer;
                    pieces[piece][1] = key;
                }
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] commandArgs = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];
                string piece = commandArgs[1];

                if (action == "Add")
                {                    
                    string composer = commandArgs[2];
                    string key = commandArgs[3];

                    if (!pieces.ContainsKey(piece))
                    {
                        pieces.Add(piece, new string[2]);
                        pieces[piece][0] = composer;
                        pieces[piece][1] = key;

                        Console.WriteLine($"{piece} by {composer} in { key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    if (pieces.ContainsKey(piece))
                    {                        
                        pieces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (action == "ChangeKey")
                {
                    string key = commandArgs[2];

                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece][1] = key;

                        Console.WriteLine($"Changed the key of {piece} to {key}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
