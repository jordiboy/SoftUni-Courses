using System;

namespace P08.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double totalScore = 0;
            int countBadScore = 0;
            int counter = 1;

            while (counter <= 12)
            {
                double score = double.Parse(Console.ReadLine());

                if (score >= 4)
                {
                    counter++;
                    totalScore += score;
                }
                else
                {                    
                    countBadScore++;

                    if (countBadScore == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {counter} grade");
                        return;
                    }
                }
            }

            double averageScore = totalScore / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageScore:f2}");
        }
    }
}
