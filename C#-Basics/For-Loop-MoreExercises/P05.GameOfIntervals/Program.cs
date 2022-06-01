using System;

namespace P05.GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameTurns = int.Parse(Console.ReadLine());
            
            double[] points = new double[7];   // i0 = points; i1 = to9; i2 = to19; i3 = to29; i4 = to39; i5 = to50; i6 = invalid numbers

            for (int i = 1; i <= gameTurns; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input >=0 && input < 10)
                {
                    points[1]++;
                    points[0] += input * 0.2;
                }
                else if (input >= 10 && input < 20)
                {
                    points[2]++;
                    points[0] += input * 0.3;
                }
                else if (input >= 20 && input < 30)
                {
                    points[3]++;
                    points[0] += input * 0.4;
                }
                else if (input >= 30 && input < 40)
                {
                    points[4]++;
                    points[0] += 50;
                }
                else if (input >= 40 && input <= 50)
                {
                    points[5]++;
                    points[0] += 100;
                }
                else
                {
                    points[6]++;
                    points[0] /= 2;
                }                
            }

            Console.WriteLine($"{points[0]:f2}");
            Console.WriteLine($"From 0 to 9: {(points[1] / gameTurns) * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(points[2] / gameTurns) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(points[3] / gameTurns) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(points[4] / gameTurns) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(points[5] / gameTurns) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(points[6] / gameTurns) * 100:f2}%");
        }
    }
}
