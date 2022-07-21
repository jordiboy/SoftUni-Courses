using System;

namespace P09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            PalindromeIntegers(command);
        }
        private static void PalindromeIntegers(string command)
        {
            while (command != "END")
            {
                string reverce = string.Empty;
                for (int i = command.Length - 1; i >= 0; i--)
                {
                    reverce += command[i];
                }

                if (command == reverce)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();
            }
        }
    }
}
