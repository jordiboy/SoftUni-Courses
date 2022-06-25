using System;

namespace P02.FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            int countWins = 0;
            int countLoss = 0;
            int countDraw = 0;

            if (first[0] > first[2])
            {
                countWins++;
            }
            else if (first[0] < first[2])
            {
                countLoss++;
            }
            else
            {
                countDraw++;
            }
            if (second[0] > second[2])
            {
                countWins++;
            }
            else if (second[0] < second[2])
            {
                countLoss++;
            }
            else
            {
                countDraw++;
            }
            if (third[0] > third[2])
            {
                countWins++;
            }
            else if (third[0] < third[2])
            {
                countLoss++;
            }
            else
            {
                countDraw++;
            }

            Console.WriteLine($"Team won {countWins} games.");
            Console.WriteLine($"Team lost {countLoss} games.");
            Console.WriteLine($"Drawn games: {countDraw}");
        }
    }
}
