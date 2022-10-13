using System;

namespace P01.Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wins = 0;
            bool isFinish = false;
            int counter = 0;

            string command = Console.ReadLine();

            while (command != "End of battle")
            {
                int distance = int.Parse(command);
                

                if (energy - distance >= 0)
                {
                    counter++;
                    energy -= distance;
                    wins++;

                    if (counter == 3)
                    {
                        energy += wins;
                        counter = 0;
                    }                    
                }
                else
                {
                    isFinish = true;
                    break;
                }

                command = Console.ReadLine();
            }

            if (isFinish)
            {
                Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
            }
            else
            {
                Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
            }
        }
    }
}
