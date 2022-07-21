using System;

namespace P03.Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());

            LettersInRange(letter1, letter2);
        }
        private static void LettersInRange(char letter1, char letter2)
        {
            if (letter2 < letter1)
            {
                for (int j = letter2 + 1; j <= letter1 - 1; j++)
                {
                    Console.Write($"{(char)j} ");
                }
            }
            else
            {
                for (int i = letter1 + 1; i <= letter2 - 1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
