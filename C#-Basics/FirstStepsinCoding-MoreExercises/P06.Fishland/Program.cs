using System;

namespace P06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double makarelPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double palamud = makarelPrice + (makarelPrice * 0.6);
            double safrid = cacaPrice + (cacaPrice * 0.8);

            palamud *= palamudKg;
            safrid *= safridKg;

            double midi = midiKg * 7.5;
            double sum = palamud + safrid + midi;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
