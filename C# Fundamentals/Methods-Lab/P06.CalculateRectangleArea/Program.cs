using System;

namespace P06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = RectangleArea(width, hight);

            Console.WriteLine(area);
        }
        static double RectangleArea(double width, double hight)
        {
            return width * hight;
        }
    }
}
