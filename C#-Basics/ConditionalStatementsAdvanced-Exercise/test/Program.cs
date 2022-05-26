using System;

namespace SoftUniExercise18thMay2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());


            double sum = 0;

            if (flower == "Roses")
            {

                sum = 5 * (double)count;
                if (count > 80)
                {
                    sum = sum - (sum * 0.1);
                }
            }
            else if (flower == "Dahlias")
            {

                sum = 3.8 * (double)count;
                if (count > 90)
                {
                    sum = sum - (sum * 0.15);
                }
            }
            else if (flower == "Tulips")
            {

                sum = 2.8 * (double)count;
                if (count > 80)
                {
                    sum = sum - (sum * 0.15);
                }
            }
            else if (flower == "Narcissus")
            {

                sum = 3 * (double)count;
                if (count < 120)
                {
                    sum = sum + (sum * 0.15);
                }
            }
            else if (flower == "Gladiolus")
            {

                sum = 2.5 * (double)count;
                if (count < 80)
                {
                    sum = sum + (sum * 0.2);
                }
            }

            double final1 = (double)budget - sum;
            double final2 = sum - (double)budget;

            if (sum < budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {final1:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {final2:f2} leva more.");
            }
        }

    }
}