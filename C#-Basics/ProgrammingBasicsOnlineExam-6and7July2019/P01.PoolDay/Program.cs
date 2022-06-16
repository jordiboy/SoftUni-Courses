using System;

namespace P01.PoolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());
            double chair = double.Parse(Console.ReadLine());
            double umbrela = double.Parse(Console.ReadLine());

            double countUmbrelas = Math.Ceiling((double)countPeople / 2);
            double countChairs = Math.Ceiling(countPeople * 0.75);

            umbrela *= countUmbrelas;
            chair *= countChairs;
            tax *= countPeople;
            double total = tax + chair + umbrela;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
