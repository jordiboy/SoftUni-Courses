using System;

namespace P01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            
            while (command != "Reveal")
            {
                string[] commandArgs = command.Split(":|:");
                string action = commandArgs[0];

                if (action == "InsertSpace")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index >= 0 && index < message.Length)
                    {
                        message = message.Insert(index, " ");

                        Console.WriteLine(message);
                    }                    
                }
                else if (action == "Reverse")
                {
                    string substring = commandArgs[1];
                    if (message.Contains(substring))
                    {
                        int index = message.IndexOf(substring);

                        message = message.Remove(index, substring.Length);

                        string newSubstring = string.Empty;
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            newSubstring += substring[i];
                        }

                        message += newSubstring;

                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    message = message.Replace(substring, replacement);

                    Console.WriteLine(message);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
