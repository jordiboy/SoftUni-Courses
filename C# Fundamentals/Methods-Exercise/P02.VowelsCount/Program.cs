using System;

namespace P02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //a, e, i, o, u

            string word = Console.ReadLine().ToLower();

            VowelsCount(word);
        }
        private static void VowelsCount(string word)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u': count++; break;
                }
            }

            Console.WriteLine(count);
        }
    }
}
