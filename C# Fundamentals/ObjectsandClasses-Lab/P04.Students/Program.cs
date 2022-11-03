using System;
using System.Collections.Generic;

namespace P04.Students
{
    class Student
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] student = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Student newStudent = new Student()
                {
                    FirstName = student[0],
                    LastName = student[1],
                    Age = int.Parse(student[2]),
                    HomeTown = student[3]
                };

                students.Add(newStudent);

                input = Console.ReadLine();
            }

            string filterCity = Console.ReadLine();

            foreach (var student in students)
            {
                if (student.HomeTown == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
