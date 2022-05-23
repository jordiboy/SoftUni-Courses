using System;

namespace P05.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            width *= 100;       // meters to sentimeters
            length *= 100;      // meters to sentimeters
                                    
            double rowPlaces = Math.Floor((width - 100) / 70);
            double colPlaces = Math.Floor(length / 120);

            double totalPlaces = (rowPlaces * colPlaces) - 3;

            Console.WriteLine(totalPlaces);

        }
    }
}
