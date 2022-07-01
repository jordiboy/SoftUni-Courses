using System;

namespace P03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double cources = Math.Ceiling((double)people / capacity);

            Console.WriteLine(cources);
        }
    }
}
