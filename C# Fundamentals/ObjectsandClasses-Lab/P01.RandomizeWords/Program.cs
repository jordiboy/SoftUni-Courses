using System;

namespace P01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                int random = rnd.Next(0, words.Length);
                words[i] = words[random];
                words[random] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
