using System;

namespace P06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDays = int.Parse(Console.ReadLine());
            int countHours = int.Parse(Console.ReadLine());

            double total = 0;
            int counter = 0;

            for (int day = 1; day <= countDays; day++)
            {
                counter++;
                double sum = 0;

                for (int hour = 1; hour <= countHours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        sum += 2.5;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }
                }

                total += sum;

                Console.WriteLine($"Day: {counter} - {sum:f2} leva");
            }

            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
