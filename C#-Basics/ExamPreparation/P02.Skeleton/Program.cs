using System;

namespace P02.Skeleton
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesControl = int.Parse(Console.ReadLine());
            int secondsControl = int.Parse(Console.ReadLine());
            double traceLength = double.Parse(Console.ReadLine());
            int secPer100Meter = int.Parse(Console.ReadLine());

            minutesControl *= 60;
            secondsControl += minutesControl;
            double slowing = (traceLength / 120) * 2.5;
            double totalTime = (traceLength / 100) * secPer100Meter - slowing;

            if (totalTime <= secondsControl)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {totalTime:f3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {totalTime - secondsControl:f3} second slower.");
            }
        }
    }
}
