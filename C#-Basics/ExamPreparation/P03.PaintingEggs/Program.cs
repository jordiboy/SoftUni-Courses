using System;

namespace P03.PaintingEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string sizeEggs = Console.ReadLine();
            string color = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            double price = 0;

            if (sizeEggs == "Large")
            {
                switch (color)
                {
                    case "Red": price = 16; break;
                    case "Green": price = 12; break;
                    case "Yellow": price = 9; break;                   
                }
            }
            else if (sizeEggs == "Medium")
            {
                switch (color)
                {
                    case "Red": price = 13; break;
                    case "Green": price = 9; break;
                    case "Yellow": price = 7; break;
                }
            }
            else if (sizeEggs == "Small")
            {
                switch (color)
                {
                    case "Red": price = 9; break;
                    case "Green": price = 8; break;
                    case "Yellow": price = 5; break;
                }
            }

            double total = count * price;
            double costs = total * 0.35;
            total -= costs;

            Console.WriteLine($"{total:f2} leva.");
        }
    }
}
