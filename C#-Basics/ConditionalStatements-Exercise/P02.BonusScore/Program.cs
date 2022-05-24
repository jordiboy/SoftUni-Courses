using System;

namespace P02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0;

            if (points <= 100)
            {
                bonusPoints += 5;
            }
            else if (points < 1000)
            {
                bonusPoints = points * 0.20;
            }
            else
            {
                bonusPoints = points * 0.10;
            }
            if (points % 2 == 0)
            {
                bonusPoints++;
            }
            else if (points % 10 == 5)
            {
                bonusPoints += 2;
            }

            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints + points);
        }
    }
}
