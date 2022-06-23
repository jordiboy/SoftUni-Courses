using System;

namespace P06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            double total = 0;            

            for (int i = 1; i <= clients; i++)
            {
                int countItems = 0;
                double price = 0;
                double sum = 0;
                string product = Console.ReadLine();

                while (product != "Finish")
                {
                    countItems++;                    

                    switch (product)
                    {
                        case "basket": price = 1.5; break;
                        case "wreath": price = 3.8; break;
                        case "chocolate bunny": price = 7; break;
                    }

                    sum += price;

                    product = Console.ReadLine();
                }
                if (countItems % 2 == 0)
                {                    
                    sum -= sum * 0.2;
                }

                Console.WriteLine($"You purchased {countItems} items for {sum:f2} leva.");

                total += sum;                
            }

            total /= clients;

            Console.WriteLine($"Average bill per client is: {total:f2} leva.");
        }
    }
}
