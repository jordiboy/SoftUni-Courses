using System;

namespace P11.RefactorVolumeofPyramid
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double area = length * width;
            double V = 1 / 3.0 * area * height;

            Console.Write($"Pyramid Volume: {V:f2}");
        }
    }
}
