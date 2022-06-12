using System;

namespace P04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jurry = int.Parse(Console.ReadLine());

            int countGrades = 0;
            double allgrades = 0;
            string presentationName;

            while ((presentationName = Console.ReadLine()) != "Finish")
            {
                double totalGrades = 0;

                for (int i = 1; i <= jurry; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    totalGrades += grades;
                    allgrades += grades;
                    countGrades++;
                }

                Console.WriteLine($"{presentationName} - {totalGrades / jurry:f2}.");
            }

            Console.WriteLine($"Student's final assessment is {allgrades / countGrades:f2}.");
        }
    }
}
