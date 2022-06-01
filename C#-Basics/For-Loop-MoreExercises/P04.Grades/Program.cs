using System;

namespace P04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());

            int countTo3 = 0;
            int countTo4 = 0;
            int countTo5 = 0;
            int countTo6 = 0;
            double allDegrees = 0;

            for (int i = 1; i <= countStudents; i++)
            {
                double degree = double.Parse(Console.ReadLine());

                allDegrees += degree;

                if (degree < 3)
                {
                    countTo3++;                    
                }
                else if (degree < 4)
                {
                    countTo4++;                    
                }
                else if (degree < 5)
                {
                    countTo5++;
                }
                else
                {
                    countTo6++;
                }
            }

            double avgDegree = allDegrees / countStudents;
            double percentTo3 = ((double)countTo3 / countStudents) * 100;
            double percentTo4 = ((double)countTo4 / countStudents) * 100;
            double percentTo5 = ((double)countTo5 / countStudents) * 100;
            double percentTo6 = ((double)countTo6 / countStudents) * 100;

            Console.WriteLine($"Top students: {percentTo6:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentTo5:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentTo4:f2}%");
            Console.WriteLine($"Fail: {percentTo3:f2}%");
            Console.WriteLine($"Average: {avgDegree:f2}");
        }
    }
}
