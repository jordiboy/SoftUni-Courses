using System;

namespace P05.SuppliesforSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPens = int.Parse(Console.ReadLine());
            int countMarkers = int.Parse(Console.ReadLine());
            int liquidLiter = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pens = countPens * 5.80;
            double markers = countMarkers * 7.20;
            double liquid = liquidLiter * 1.20;
            double total = pens + markers + liquid;
            double percent = total * (discount / 100.0);            
            total -= percent;
            Console.WriteLine(total);
        }
    }
}
