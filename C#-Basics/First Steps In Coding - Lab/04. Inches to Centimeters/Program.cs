using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double sentimeters = inches * 2.54;
            Console.WriteLine(sentimeters);
        }
    }
}
