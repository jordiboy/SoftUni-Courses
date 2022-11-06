using System;
using System.Linq;
using System.Collections.Generic;

namespace P02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();                

            var words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                string wordLC = word.ToLower();

                if (!words.ContainsKey(wordLC))
                {
                    words.Add(wordLC, 1);
                }
                else
                {
                    words[wordLC]++;
                }
            }

            foreach (var item in words)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
