using System;

namespace P07.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int volume = a * b * c;
            int boxes = 0;

            while (boxes < volume)
            {
                string input = Console.ReadLine();

                if (input != "Done")
                {
                    int curentBoxes = int.Parse(input);
                    boxes += curentBoxes;
                }
                else
                {
                    break;
                }
            }

            if (boxes < volume)
            {
                Console.WriteLine($"{volume - boxes} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {boxes - volume} Cubic meters more.");
            }
        }
    }
}
