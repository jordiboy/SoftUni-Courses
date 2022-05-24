using System;

namespace P01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int sum = firstTime + secondTime + thirdTime;
            int minutes = sum / 60;
            int seconds = sum % 60;

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
