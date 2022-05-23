using System;

namespace P03.CelsiustoFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double farenheit = celsius * 1.8 + 32;

            Console.WriteLine($"{farenheit:f2}");
        }
    }
}
