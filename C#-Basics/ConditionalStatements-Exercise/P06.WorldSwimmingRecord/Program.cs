using System;

namespace P06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double totalTime = meters * secondsPerMeter;
            double slowing = Math.Floor(meters / 15);
            slowing *= 12.5;
            totalTime += slowing;

            if (record > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
        }
    }
}
