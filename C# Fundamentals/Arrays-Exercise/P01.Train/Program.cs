using System;
using System.Linq;

namespace P01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] wagons = new int[n];

            for (int i = 0; i < n; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(string.Join(" ", wagons));
            Console.WriteLine();
            Console.WriteLine(wagons.Sum());
        }
    }
}
