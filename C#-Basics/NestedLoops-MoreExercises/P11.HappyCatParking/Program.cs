using System;

namespace P11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= days; i++)
            {                
                double daylyPrice = 0;

                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        daylyPrice += 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        daylyPrice += 1.25;
                    }
                    else
                    {
                        daylyPrice += 1;
                    }                    
                }

                total += daylyPrice;
                Console.WriteLine($"Day: {i} - {daylyPrice:f2} leva");                
            }

            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
