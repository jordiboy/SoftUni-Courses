using System;
using System.Linq;

namespace P04.ReverseArrayofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chars = Console.ReadLine()
                .Split()                
                .ToArray();

            for (int i = chars.Length -1; i >= 0; i--)
            {
                Console.Write($"{chars[i]} ");
            }
        }
    }
}
