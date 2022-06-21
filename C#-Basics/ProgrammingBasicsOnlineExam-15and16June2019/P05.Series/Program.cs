using System;

namespace P05.Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countSerials = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= countSerials; i++)
            {
                string serialName = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                                
                switch (serialName)
                {
                    case "Thrones": price -= price * 0.5; break;
                    case "Lucifer": price -= price * 0.4; break;
                    case "Protector": price -= price * 0.3; break;
                    case "TotalDrama": price -= price * 0.2; break;
                    case "Area": price -= price * 0.1; break;
                }

                total += price;
            }

            if (budget >= total)
            {
                Console.WriteLine($"You bought all the series and left with {budget - total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {total - budget:f2} lv. more to buy the series!");
            }
        }
    }
}
