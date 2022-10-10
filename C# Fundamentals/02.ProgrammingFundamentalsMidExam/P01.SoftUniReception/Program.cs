using System;

namespace P01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1 = int.Parse(Console.ReadLine());
            int employee2 = int.Parse(Console.ReadLine());
            int employee3 = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int hours = 0;
            int hourCount = 0;

            int allEmployeesPerHour = employee1 + employee2 + employee3;

            while (studentsCount > 0)
            {
                hourCount++;
                hours++;

                if (hourCount < 4)
                {
                    studentsCount -= allEmployeesPerHour;                    
                }
                else
                {
                    hourCount = 0;
                }                
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
