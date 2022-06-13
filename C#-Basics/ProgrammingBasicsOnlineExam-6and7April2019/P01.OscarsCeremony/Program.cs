using System;

namespace P01.OscarsCeremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statues = rent - (rent * 0.3);
            double katering = statues - (statues * 0.15);
            double sound = katering - (katering * 0.5);

            double sum = rent + statues + katering + sound;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
