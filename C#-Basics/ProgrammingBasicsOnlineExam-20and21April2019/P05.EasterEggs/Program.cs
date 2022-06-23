using System;
using System.Linq;

namespace P05.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPaintedEggs = int.Parse(Console.ReadLine());

            int[] colors = new int[4];
            string maxColor = string.Empty;

            for (int i = 1; i <= countPaintedEggs; i++)
            {
                string color = Console.ReadLine();

                switch (color)
                {
                    case "red": colors[0]++; break;
                    case "orange": colors[1]++; break;
                    case "blue": colors[2]++; break;
                    case "green": colors[3]++; break;
                }
            }

            int max = colors.Max();

            if (max == colors[0])
            {
                maxColor = "red";
            }
            else if (max == colors[1])
            {
                maxColor = "orange";
            }
            else if (max == colors[2])
            {
                maxColor = "blue";
            }
            else if (max == colors[3])
            {
                maxColor = "green";
            }

            Console.WriteLine($"Red eggs: {colors[0]}");
            Console.WriteLine($"Orange eggs: {colors[1]}");
            Console.WriteLine($"Blue eggs: {colors[2]}");
            Console.WriteLine($"Green eggs: {colors[3]}");
            Console.WriteLine($"Max eggs: {max} -> {maxColor}");
        }
    }
}
