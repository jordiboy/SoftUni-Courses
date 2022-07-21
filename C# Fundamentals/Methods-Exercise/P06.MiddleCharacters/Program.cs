using System;

namespace P06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            MiddleCharacters(word);
        }
        private static void MiddleCharacters(string word)
        {
            int middle = 0;

            if (word.Length % 2 == 0)
            {
                middle = word.Length / 2;

                Console.WriteLine($"{word[middle - 1]}{word[middle]}");
            }
            else
            {
                middle = word.Length / 2;

                Console.WriteLine(word[middle]);
            }
        }
    }
}
