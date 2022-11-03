using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.Students2._0
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

                string firstName = student[0];
                string lastName = student[1];
                int age = int.Parse(student[2]);
                string homeTown = student[3];                

                Student ExistingStudent = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (ExistingStudent == null)
                {
                    Student newstudent = new Student();
                    {
                        newstudent.FirstName = firstName;
                        newstudent.LastName = lastName;
                        newstudent.Age = age;
                        newstudent.HomeTown = homeTown;
                    }

                    students.Add(newstudent);
                }
                else
                {                    
                    ExistingStudent.Age = age;
                    ExistingStudent.HomeTown = homeTown;
                }                

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
