
using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.OrderbyAge
{
    public class Person
    {
        public Person(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persones = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {                
                string[] inputArgs = input.Split();
                string name = inputArgs[0];
                string iD = inputArgs[1];
                int age = int.Parse(inputArgs[2]);

                Person newPerson = new Person(name, iD, age);

                Person person = persones.FirstOrDefault(i => i.ID == iD);      

                if (person != null)
                {
                    person.Name = name;
                    person.Age = age;                    
                }
                else
                {
                    persones.Add(newPerson);
                }                                               

                input = Console.ReadLine();
            }

            foreach (var person in persones.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }
}
