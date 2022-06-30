using System;

namespace P09.CharstoString
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

            Console.Write(string.Join("", chars));
        }
    }
}
