using System;

namespace P07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string space = Console.ReadLine();

            Console.WriteLine($"{name1}{space}{name2}");
        }
    }
}
