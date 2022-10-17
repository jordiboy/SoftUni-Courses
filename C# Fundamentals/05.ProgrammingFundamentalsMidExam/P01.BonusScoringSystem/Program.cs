using System;

namespace P01.BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());

            int maxBonus = 0;
            int lectures = 0;
             
            for (int i = 1; i <= countStudents; i++)
            {
                int attendance = int.Parse(Console.ReadLine());

                double totalBonus = Math.Ceiling((double)attendance / countLectures * (5 + addBonus));

                if (maxBonus < totalBonus)
                {
                    maxBonus = (int)totalBonus;
                    lectures = attendance;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {lectures} lectures.");
        }
    }
}
