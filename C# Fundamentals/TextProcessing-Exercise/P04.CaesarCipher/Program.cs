using System;
using System.Text;

namespace P04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                int currChar = text[i] + 3;
                char result = (char)currChar;

                sb.Append(result);
            }

            Console.WriteLine(sb);
        }
    }
}
