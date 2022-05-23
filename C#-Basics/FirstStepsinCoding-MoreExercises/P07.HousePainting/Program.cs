using System;

namespace P07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double houseHigh = double.Parse(Console.ReadLine());
            double houseLength = double.Parse(Console.ReadLine());
            double roofHigh = double.Parse(Console.ReadLine());

            double frontAndBehind = 2 * (houseHigh * houseHigh);
            double door = 1.2 * 2;
            frontAndBehind -= door;
            double twoSides = 2 * (houseHigh * houseLength);
            double window = 2 * (1.5 * 1.5);
            twoSides -= window;
            
            double greenPaint = (frontAndBehind + twoSides) / 3.4;

            double roofSides = 2 * (houseLength * houseHigh);
            double roofTrianleSides = 2 * (houseHigh * roofHigh / 2);

            double redPaint = (roofSides + roofTrianleSides) / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
