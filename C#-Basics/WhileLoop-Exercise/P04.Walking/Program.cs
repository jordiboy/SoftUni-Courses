using System;

namespace P04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetSteps = 10000;
            int curentSteps = 0;

            while (curentSteps < targetSteps)
            {
                string input = Console.ReadLine();
                if (input != "Going home")
                {
                    int inputSteps = int.Parse(input);
                    curentSteps += inputSteps;
                }
                else
                {
                    int inputSteps = int.Parse(Console.ReadLine());
                    curentSteps += inputSteps;
                    break;
                }
            }

            if (curentSteps >= targetSteps)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{curentSteps - targetSteps} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{targetSteps - curentSteps} more steps to reach goal.");
            }
        }
    }
}
