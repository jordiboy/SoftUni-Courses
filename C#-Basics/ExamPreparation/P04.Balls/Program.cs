using System;

namespace P04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] colorCount = new int[6];
            double points = 0;

            for (int i = 1; i <= n; i++)
            {
                string color = Console.ReadLine();                
                
                switch (color)
                {
                    case "red": points += 5; colorCount[0]++; break;
                    case "orange": points += 10; colorCount[1]++; break;
                    case "yellow": points += 15; colorCount[2]++; break;
                    case "white": points += 20; colorCount[3]++; break;
                    case "black": points /= 2;colorCount[4]++; break;
                    default: colorCount[5]++; break;
                }
            }

            Console.WriteLine($"Total points: {Math.Floor(points)}");
            Console.WriteLine($"Red balls: {colorCount[0]}");
            Console.WriteLine($"Orange balls: {colorCount[1]}");
            Console.WriteLine($"Yellow balls: {colorCount[2]}");
            Console.WriteLine($"White balls: {colorCount[3]}");
            Console.WriteLine($"Other colors picked: {colorCount[5]}");
            Console.WriteLine($"Divides from black balls: {colorCount[4]}");
        }
    }
}
