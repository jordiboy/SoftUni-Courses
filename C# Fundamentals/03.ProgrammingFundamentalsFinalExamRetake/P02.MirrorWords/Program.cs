using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace P02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";

            string input = Console.ReadLine();

            var wordPairs = new List<string>();
            var matchedWords = Regex.Matches(input, pattern);

            if (matchedWords.Count == 0)
            {
                Console.WriteLine("No word pairs found!");                
            }
            else
            {
                foreach (Match wordPair in matchedWords)
                {
                    string word1 = wordPair.Groups["word1"].Value;
                    string word2 = wordPair.Groups["word2"].Value;

                    if (word1.Length == word2.Length)
                    {
                        string reversedWord = string.Empty;

                        for (int i = word2.Length - 1; i >= 0; i--)
                        {
                            reversedWord += word2[i];
                        }

                        if (word1 == reversedWord)
                        {
                            string result = $"{word1} <=> {word2}";
                            wordPairs.Add(result);
                        }
                    }
                }
            }
            if (matchedWords.Count > 0)
            {
                Console.WriteLine($"{matchedWords.Count} word pairs found!");
            }

            if (wordPairs.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", wordPairs));
            }
        }
    }
}
