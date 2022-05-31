using System;

namespace P03.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double[] histogram = new double[5];         // i0 = p1, i1 = p2, i2 = p3, i3 = p4, i4 = p5

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    histogram[0]++;
                }
                else if (num < 400)
                {
                    histogram[1]++;
                }
                else if (num < 600)
                {
                    histogram[2]++;
                }
                else if (num < 800)
                {
                    histogram[3]++;
                }
                else
                {
                    histogram[4]++;
                }
            }            

            Console.WriteLine($"{(histogram[0] / n) * 100:f2}%");
            Console.WriteLine($"{(histogram[1] / n) * 100:f2}%");
            Console.WriteLine($"{(histogram[2] / n) * 100:f2}%");
            Console.WriteLine($"{(histogram[3] / n) * 100:f2}%");
            Console.WriteLine($"{(histogram[4] / n) * 100:f2}%");
        }
    }
}
