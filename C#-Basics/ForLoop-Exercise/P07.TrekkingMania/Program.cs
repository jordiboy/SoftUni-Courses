using System;

namespace P07.TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int countGroups = int.Parse(Console.ReadLine());
           
            int countPersones = 0;
            double[] mountains = new double[5];         // i0 = musala, i1 = monblan, i2 = kilimanjaro, i3 = k2, i4 = everest

            for (int i = 1; i <= countGroups; i++)
            {
                int countPeople = int.Parse(Console.ReadLine());

                countPersones += countPeople;

                if (countPeople < 6)
                {                    
                    mountains[0] += countPeople;
                }
                else if (countPeople < 13)
                {                    
                    mountains[1] += countPeople;
                }
                else if (countPeople < 26)
                {                    
                    mountains[2] += countPeople;
                }
                else if (countPeople < 41)
                {
                    mountains[3] += countPeople;
                }
                else
                {
                    mountains[4] += countPeople;
                }
            }            

            Console.WriteLine($"{(mountains[0] / countPersones) * 100:f2}%");
            Console.WriteLine($"{(mountains[1] / countPersones) * 100:f2}%");
            Console.WriteLine($"{(mountains[2] / countPersones) * 100:f2}%");
            Console.WriteLine($"{(mountains[3] / countPersones) * 100:f2}%");
            Console.WriteLine($"{(mountains[4] / countPersones) * 100:f2}%");
        }
    }
}
