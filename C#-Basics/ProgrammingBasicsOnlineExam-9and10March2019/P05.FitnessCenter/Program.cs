using System;
using System.Linq;

namespace P05.FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int countVisitors = int.Parse(Console.ReadLine());
                        
            double[] fitnessCounter = new double[4];
            double[] productCounter = new double[2];

            for (int i = 1; i <= countVisitors; i++)
            {
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "back": fitnessCounter[0]++; break;
                    case "chest": fitnessCounter[1]++; break;
                    case "legs": fitnessCounter[2]++; break;
                    case "abs": fitnessCounter[3]++; break;
                    case "protein shake": productCounter[0]++; break;
                    case "protein bar": productCounter[1]++; break;
                }
            }

            double allFitness = fitnessCounter[0] + fitnessCounter[1] + fitnessCounter[2] + fitnessCounter[3];
            double allProducts = productCounter[0] + productCounter[1];

            Console.WriteLine($"{fitnessCounter[0]} - back");
            Console.WriteLine($"{fitnessCounter[1]} - chest");
            Console.WriteLine($"{fitnessCounter[2]} - legs");
            Console.WriteLine($"{fitnessCounter[3]} - abs");
            Console.WriteLine($"{productCounter[0]} - protein shake");
            Console.WriteLine($"{productCounter[1]} - protein bar");
            Console.WriteLine($"{(allFitness / countVisitors) * 100:f2}% - work out");
            Console.WriteLine($"{(allProducts / countVisitors) * 100:f2}% - protein");
        }
    }
}
