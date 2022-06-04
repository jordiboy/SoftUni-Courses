using System;

namespace P03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForExcursion = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendCounter = 0;

            while (budget < moneyForExcursion)
            {
                string spendOrSave = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                daysCounter++;

                if (spendOrSave == "save")
                {
                    budget += money;
                    spendCounter = 0;
                }
                else
                {
                    budget -= money;
                    spendCounter++;

                    if (spendCounter == 5)
                    {                        
                        break;
                    }
                }

                if (budget < 0)
                {
                    budget = 0;
                }
            }

            if (budget >= moneyForExcursion)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
        }
    }
}
