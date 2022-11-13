using System;

namespace P08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()  //A12b s17G
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            decimal sum = 0;

            foreach (var word in words)
            {
                sum += WordCalculation(word);
            }

            Console.WriteLine($"{sum:f2}");
        }
        public static decimal WordCalculation(string word)
        {
            decimal sum = 0;
            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int number = int.Parse(word.Substring(1, word.Length - 2));

            if (char.IsUpper(firstLetter))
            {
                sum = (decimal)number / CharToNumber(firstLetter);
            }
            else if (char.IsLower(firstLetter))
            {
                sum = (decimal)number * CharToNumber(firstLetter);
            }

            if (char.IsUpper(lastLetter))
            {
                sum -= CharToNumber(lastLetter);
            }
            else if (char.IsLower(lastLetter))
            {
                sum += CharToNumber(lastLetter);
            }

            return sum;
        }
        public static int CharToNumber(char ch)
        {
            return char.ToLower(ch) - 96;
        }
    }
}
