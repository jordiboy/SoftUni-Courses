using System;

namespace P02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            GradeDefine(grade);
        }
        public static void GradeDefine(double grades)
        {
            if (grades >= 2 && grades <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grades >= 3 && grades <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grades >= 3.5 && grades <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grades >= 4.5 && grades <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grades >= 5.5 && grades <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
