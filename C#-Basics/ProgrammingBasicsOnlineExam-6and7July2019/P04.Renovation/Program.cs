using System;

namespace P04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int hight = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            double area = hight * width * 4;
            double notPainted = area * (percent / 100.0);
            double areaForPainting = Math.Ceiling(area - notPainted);
            int totalLitters = 0;            

            string input = Console.ReadLine();

            while (input != "Tired!")
            {
                int paintLitters = int.Parse(input);

                totalLitters += paintLitters;

                if (totalLitters >= areaForPainting)
                {
                    break;
                }                
                
                input = Console.ReadLine();
            }

            if (input == "Tired!")
            {
                Console.WriteLine($"{areaForPainting - totalLitters} quadratic m left.");
            }
            else if (totalLitters > areaForPainting)
            {
                Console.WriteLine($"All walls are painted and you have {totalLitters - areaForPainting} l paint left!");
            }
            else
            {
                Console.WriteLine("All walls are painted! Great job, Pesho!");
            }
        }
    }
}
