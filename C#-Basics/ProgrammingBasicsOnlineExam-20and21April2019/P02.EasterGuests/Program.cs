using System;

namespace P02.EasterGuests
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double breads = Math.Ceiling(countGuests / 3.0);
            double eggs = countGuests * 2;

            double priceBreads = breads * 4;
            double priceEggs = eggs * 0.45;

            double total = priceBreads + priceEggs;

            if (budget >= total)
            {
                Console.WriteLine($"Lyubo bought {breads} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {budget - total:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {total - budget:f2} lv. more.");
            }
        }
    }
}
