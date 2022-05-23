using System;

namespace P09.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine().ToLower();

            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
