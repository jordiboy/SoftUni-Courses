using System;

namespace P06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[3];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
            }

            for (int i = chars.Length - 1; i > -1; i--)
            {
                Console.Write($"{chars[i]} ");
            }
        }
    }
}
