using System;

namespace P02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            CloserPointToZero(x, y, x1, y1);
        }
        static void CloserPointToZero(double x, double y, double x1, double y1)
        {
            double first = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double secound = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

            if (first <= secound)
            {
                Console.WriteLine($"({x}, {y})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }    
    }
}
