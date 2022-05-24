using System;

namespace P07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countVideo = int.Parse(Console.ReadLine());
            int countprocessor = int.Parse(Console.ReadLine());
            int countRam = int.Parse(Console.ReadLine());

            double videocards = countVideo * 250;
            double processor = (videocards * 0.35) * countprocessor;
            double ram = (videocards * 0.1) * countRam;
            double sum = videocards + processor + ram;

            if (countVideo > countprocessor)
            {
                double discount = sum * 0.15;
                sum -= discount;
            }

            if (budget >= sum)
            {
                Console.WriteLine($"You have {budget - sum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
            }
        }
    }
}
