using System;

namespace P04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int countDays = int.Parse(Console.ReadLine());

            int hours = countPages / pagesPerHour;
            hours /= countDays;
            Console.WriteLine(hours);
        }
    }
}
