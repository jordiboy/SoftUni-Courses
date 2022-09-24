using System;

namespace P05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int temp = character;
                int newChar = temp + key;

                word += (char)newChar;
            }
            Console.WriteLine(word);
        }
    }
}
