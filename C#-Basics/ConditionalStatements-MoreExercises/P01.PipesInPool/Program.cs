using System;

namespace P01.PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1 = p1 * hours;
            double pipe2 = p2 * hours;
            double totalWater = pipe1 + pipe2;
            double pipe1Percent = (pipe1 / totalWater) * 100;
            double pipe2Percent = (pipe2 / totalWater) * 100;

            if (totalWater <= v)
            {
                double percentFull = (totalWater / v) * 100;
                Console.WriteLine($"The pool is {percentFull:f2}% full. Pipe 1: {pipe1Percent:f2}%. Pipe 2: {pipe2Percent:f2}%.");
            }
            else
            {
                double overflow = totalWater - v;
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overflow:f2} liters.");
            }
        }
    }
}
