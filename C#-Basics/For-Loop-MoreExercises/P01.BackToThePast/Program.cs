using System;

namespace P01.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            int yearBack = 1800;
            int yearsoldCounter = 18;            

            for (int i = yearBack; i <= year; i++)
            {
                double moneyUsed = 0;

                if (i %2 == 0)
                {
                    moneyUsed += 12000;
                    money -= moneyUsed;
                }
                else
                {
                    moneyUsed = 12000 + 50.0 * yearsoldCounter;
                    money -= moneyUsed;
                }

                yearsoldCounter++;
            }

            if (money >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {money:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(money):f2} dollars to survive.");
            }
        }
    }
}
