using System;

namespace P03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            double maxScore = 20;
            double difficulty = 0;
            double performance = 0;

            if (country == "Russia")
            {
                switch (instrument)
                {
                    case "ribbon": difficulty = 9.1; performance = 9.4; break;
                    case "hoop": difficulty = 9.3; performance = 9.8; break;
                    case "rope": difficulty = 9.6; performance = 9; break;
                }
            }
            else if (country == "Bulgaria")
            {
                switch (instrument)
                {
                    case "ribbon": difficulty = 9.6; performance = 9.4; break;
                    case "hoop": difficulty = 9.55; performance = 9.75; break;
                    case "rope": difficulty = 9.5; performance = 9.4; break;
                }
            }
            else if (country == "Italy")
            {
                switch (instrument)
                {
                    case "ribbon": difficulty = 9.2; performance = 9.5; break;
                    case "hoop": difficulty = 9.45; performance = 9.35; break;
                    case "rope": difficulty = 9.7; performance = 9.15; break;
                }
            }

            double totalScore = difficulty + performance;

            Console.WriteLine($"The team of {country} get {totalScore:f3} on {instrument}.");
            Console.WriteLine($"{100 - ((totalScore / maxScore) * 100):f2}%");
        }
    }
}
