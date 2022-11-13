using System;
using System.Linq;

namespace P03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine()
                .Split("\\")
                .Last();

            int index = file.LastIndexOf('.');

            string filename = file.Substring(0, index);
            string extension = file.Substring(index + 1);

            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
