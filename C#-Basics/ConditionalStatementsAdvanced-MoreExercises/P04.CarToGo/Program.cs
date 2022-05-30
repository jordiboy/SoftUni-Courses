using System;

namespace P04.CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string carClass;
            string carType = "";

            if (budget < 101)
            {
                carClass = "Economy class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    budget *= 0.35;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    budget *= 0.65;
                }
            }
            else if (budget < 501)
            {
                carClass = "Compact class";

                if (season == "Summer")
                {
                    carType = "Cabrio";
                    budget *= 0.45;
                }
                else if (season == "Winter")
                {
                    carType = "Jeep";
                    budget *= 0.8;
                }
            }
            else
            {
                carClass = "Luxury class";
                carType = "Jeep";
                budget *= 0.9;
            }

            Console.WriteLine(carClass);
            Console.WriteLine($"{carType} - {budget:f2}");
        }
    }
}
