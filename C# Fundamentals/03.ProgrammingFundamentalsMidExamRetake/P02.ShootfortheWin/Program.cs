using System;
using System.Linq;

namespace P02.ShootfortheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            string command = Console.ReadLine();

            while (command != "End")
            {
                int target = int.Parse(command);
                int currtarget = 0;

                if (target > -1 && target < targets.Length)
                {
                    currtarget = targets[target];
                }
                else
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (currtarget > -1)
                {
                    targets[target] = -1;
                    counter++;

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] > currtarget)
                        {
                            targets[i] -= currtarget;
                        }
                        else if (targets[i] <= currtarget && targets[i] > -1)
                        {
                            targets[i] += currtarget;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {counter} -> {string.Join(" ", targets)}");
        }
    }
}
