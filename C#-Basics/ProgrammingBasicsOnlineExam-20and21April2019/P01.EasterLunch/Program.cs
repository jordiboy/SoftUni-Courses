using System;

namespace P01.EasterLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            int countBreads = int.Parse(Console.ReadLine());
            int countEggsPackage = int.Parse(Console.ReadLine());
            int kgBisquits = int.Parse(Console.ReadLine());

            double breads = countBreads * 3.2;
            double eggs = countEggsPackage * 4.35;
            double paintForEggs = countEggsPackage * 12 * 0.15;
            double bisquits = kgBisquits * 5.4;

            double total = breads + eggs + paintForEggs + bisquits;

            Console.WriteLine($"{total:f2}");
        }
    }
}
