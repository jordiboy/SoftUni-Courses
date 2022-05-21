using System;

namespace P09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double usedSpace = double.Parse(Console.ReadLine());
            int vol = a * b * c;
            double litters = vol * 0.001;
            double used = usedSpace / 100;
            double freeSpace = litters * (1 - used);
            Console.WriteLine(freeSpace);
        }
    }
}
