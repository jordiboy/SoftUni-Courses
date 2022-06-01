using System;

namespace P03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double priceBus = 0;
            double priceTruck = 0;
            double priceTrain = 0;
            int tonsBus = 0;
            int tonsTruck = 0;
            int tonsTrain = 0;

            for (int i = 1; i <= count; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight < 4)
                {
                    priceBus += weight * 200.0;
                    tonsBus += weight;
                }
                else if (weight < 12)
                {
                    priceTruck += weight * 175.0;
                    tonsTruck += weight;
                }
                else
                {
                    priceTrain += weight * 120.0;
                    tonsTrain += weight;
                }
            }

            double totalPrice = priceBus + priceTruck + priceTrain;            
            int totalTons = tonsBus + tonsTruck + tonsTrain;

            double avgPrice = totalPrice / totalTons;
            double percentBus = ((double)tonsBus / totalTons) * 100;
            double percentTruck = ((double)tonsTruck / totalTons) * 100;
            double percentTrain = ((double)tonsTrain / totalTons) * 100;

            Console.WriteLine($"{avgPrice:f2}");
            Console.WriteLine($"{percentBus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
