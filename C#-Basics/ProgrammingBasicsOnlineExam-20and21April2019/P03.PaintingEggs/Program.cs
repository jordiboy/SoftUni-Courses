using System;

namespace P03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggsSize = Console.ReadLine();
            string eggsColor = Console.ReadLine();
            int countPackage = int.Parse(Console.ReadLine());

            double price = 0;

            if (eggsColor == "Red")
            {
                switch (eggsSize)
                {
                    case "Large": price = 16; break;
                    case "Medium": price = 13; break;
                    case "Small": price = 9; break;
                }
            }
            else if (eggsColor == "Green")
            {
                switch (eggsSize)
                {
                    case "Large": price = 12; break;
                    case "Medium": price = 9; break;
                    case "Small": price = 8; break;
                }
            }
            else if (eggsColor == "Yellow")
            {
                switch (eggsSize)
                {
                    case "Large": price = 9; break;
                    case "Medium": price = 7; break;
                    case "Small": price = 5; break;
                }
            }

            double total = countPackage * price;
            double expenses = total * 0.35;
            total -= expenses;

            Console.WriteLine($"{total:f2} leva.");
        }
    }
}
