using System;
using System.Collections.Generic;

namespace P05.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split(" : ");
                string course = inputArgs[0];
                string student = inputArgs[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(student);
                }
                else
                {
                    courses[course].Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var course in courses)
            {                
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
