using System;

namespace P01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] commandArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "TakeOdd")
                {
                    string newPass = string.Empty;

                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newPass += password[i];
                        }                        
                    }
                    password = newPass;

                    Console.WriteLine(password);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(commandArgs[1]);
                    int length = int.Parse(commandArgs[2]);

                    password = password.Remove(index, length);

                    Console.WriteLine(password);
                }
                else if (action == "Substitute")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, replacement);

                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    } 
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
