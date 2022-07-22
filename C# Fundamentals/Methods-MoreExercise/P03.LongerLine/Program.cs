using System;

namespace P03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void LongerLine(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            double first = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double secound = Math.Pow(x2, 2) + Math.Pow(y2, 2);

            double third = Math.Pow(x3, 2) + Math.Pow(y3, 2);
            double forth = Math.Pow(x4, 2) + Math.Pow(y4, 2);

            double firstLine = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
            double secondLine = Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2);

            if (firstLine >= secondLine)
            {
                if (first <= secound)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (third <= forth)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }    
    }
}
