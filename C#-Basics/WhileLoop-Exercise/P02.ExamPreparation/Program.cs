using System;

namespace P02.ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            int countProblems = 0;
            string lastProblem = "";
            int countBadGrades = 0;
            double sumScore = 0;
            string problem;

            while ((problem = Console.ReadLine()) != "Enough")
            {
                lastProblem = problem;
                countProblems++;

                int grade = int.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    countBadGrades++;

                    if (countBadGrades == badGrades)
                    {
                        Console.WriteLine($"You need a break, {badGrades} poor grades.");
                        return;
                    }
                }

                sumScore += grade;
            }

            double avgScore = sumScore / countProblems;

            Console.WriteLine($"Average score: {avgScore:f2}");
            Console.WriteLine($"Number of problems: {countProblems}");
            Console.WriteLine($"Last problem: {lastProblem}");
        }
    }
}
