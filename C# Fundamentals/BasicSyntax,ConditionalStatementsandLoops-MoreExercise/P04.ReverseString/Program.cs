using System;

namespace P04.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();            

            for (int i = input.Length - 1; i > -1; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
