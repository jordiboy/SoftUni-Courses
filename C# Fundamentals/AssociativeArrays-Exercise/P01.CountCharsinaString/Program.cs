using System;
using System.Collections.Generic;

namespace P01.CountCharsinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            var chars = new Dictionary<char, int>();

            for (int i = 0; i < words.Length; i++)
            {
                int charsCount = words[i].Length;
                string word = words[i];

                for (int j = 0; j < charsCount; j++)
                {
                    if (!chars.ContainsKey(word[j]))
                    {
                        chars.Add(word[j], 1);
                    }
                    else
                    {
                        chars[word[j]]++;
                    }
                }
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
