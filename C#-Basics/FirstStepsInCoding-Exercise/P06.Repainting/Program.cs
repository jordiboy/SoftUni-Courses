using System;

namespace P06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPvc = int.Parse(Console.ReadLine());
            int countPaint = int.Parse(Console.ReadLine());
            int countLiquid = int.Parse(Console.ReadLine());
            int countHours = int.Parse(Console.ReadLine());

            double pvc = (countPvc + 2) * 1.50;
            double paint = (countPaint + (countPaint * 0.10)) * 14.50;
            double liquid = countLiquid * 5;
            double sum = pvc + paint + liquid + 0.4;
            double priceWork = (sum * 0.30) * countHours;
            double total = sum + priceWork;
            Console.WriteLine(total);

        }
    }
}
