using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.RemoveNegativesandReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            numbers.RemoveAll(x => x < 0);
            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));
            }            
        }
    }
}
