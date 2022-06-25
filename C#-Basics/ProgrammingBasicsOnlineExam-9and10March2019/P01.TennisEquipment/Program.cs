using System;

namespace P01.TennisEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double racketPrice = double.Parse(Console.ReadLine());
            int countRackets = int.Parse(Console.ReadLine());
            int countSneekers = int.Parse(Console.ReadLine());

            double rackets = racketPrice * countRackets;
            double sneekersPrice = racketPrice / 6;
            double sneekers = countSneekers * sneekersPrice;
            double other = (rackets + sneekers) * 0.2;

            double total = rackets + sneekers + other;

            double priceJokovich = total / 8;
            double priceSponsors = total * 7 / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(priceJokovich)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(priceSponsors)}");
        }
    }
}
