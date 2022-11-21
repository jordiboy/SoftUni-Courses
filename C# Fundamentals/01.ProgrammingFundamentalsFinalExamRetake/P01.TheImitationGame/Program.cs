using System;
using System.Text;

namespace P01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
                        
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] commandArgs = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Move")
                {
                    int numLetters = int.Parse(commandArgs[1]);

                    for (int i = 0; i < numLetters; i++)
                    {
                        char temp = ' ';
                        temp = message[0];
                        message = message.Remove(0, 1);
                        message = message.Insert(message.Length, temp.ToString());
                    }
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[1]);
                    string value = commandArgs[2];
                    message = message.Insert(index, value);
                }
                else if (action == "ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];
                    message = message.Replace(substring, replacement);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
