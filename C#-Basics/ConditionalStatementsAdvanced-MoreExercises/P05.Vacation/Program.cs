using System;

namespace P05.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string accomodation;

            if (budget < 1001)
            {
                accomodation = "Camp";

                if (season == "Summer")
                {
                    destination = "Alaska";
                    budget *= 0.65;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    budget *= 0.45;
                }
            }
            else if (budget < 3001)
            {
                accomodation = "Hut";

                if (season == "Summer")
                {
                    destination = "Alaska";
                    budget *= 0.8;
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    budget *= 0.6;
                }
            }
            else
            {
                accomodation = "Hotel";
                budget *= 0.9;

                if (season == "Summer")
                {
                    destination = "Alaska";
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                }
            }

            Console.WriteLine($"{destination} - {accomodation} - {budget:f2}");
        }
    }
}
