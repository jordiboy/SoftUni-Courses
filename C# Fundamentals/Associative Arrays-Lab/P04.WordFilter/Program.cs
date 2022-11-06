using System;
using System.Linq;

namespace P04.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
