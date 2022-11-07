using System;
using System.Collections.Generic;

namespace P06.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, double[]>();

            for (int i = 0; i < count; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new double[2]);
                    students[student][0] = grade;
                    students[student][1] = 1;
                }
                else
                {
                    students[student][0] += grade;
                    students[student][1]++;
                }
            }

            foreach (var student in students)
            {
                if (student.Value[0] / student.Value[1] >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value[0] / student.Value[1]:f2}");
                }
            }
        }
    }
}
