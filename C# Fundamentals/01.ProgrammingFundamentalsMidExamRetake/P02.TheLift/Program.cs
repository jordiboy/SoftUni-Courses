using System;
using System.Linq;

namespace P02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < lift.Length; i++)
            { 
                while (lift[i] < 4 && people > 0)
                {                    
                    people--;
                    lift[i]++;
                }
            }

            if (people == 0 && lift.Sum() / 4 != lift.Length)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", lift));
            }
            else
            {
                Console.WriteLine(string.Join(" ", lift));
            }
            
        }
    }
}
