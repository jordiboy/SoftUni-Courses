using System;

namespace P07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(word, count));
        }
        private static string RepeatString(string word, int count)
        {
            string result = "";

            for (int i = 1; i <= count; i++)
            {
                result += word;
            }

            return result;
        }
    }
}
