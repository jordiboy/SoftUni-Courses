using System;

namespace P01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());

            bottlesDetergent *= 750;

            int[] count = new int[3];                   // i0 = countLoads; i1 = countDishes; i2 = countPots
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                int countKitchenware = int.Parse(input);                

                count[0]++;

                if (count[0] % 3 == 0)
                {
                    //pots
                    bottlesDetergent -= countKitchenware * 15;
                    count[2] += countKitchenware;
                }
                else
                {
                    //dishes
                    bottlesDetergent -= countKitchenware * 5;
                    count[1] += countKitchenware;
                }

                if (bottlesDetergent < 0)
                {
                    break;
                }
            }

            if (bottlesDetergent < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(bottlesDetergent)} ml. more necessary!");
            }
            else
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{count[1]} dishes and {count[2]} pots were washed.");
                Console.WriteLine($"Leftover detergent {bottlesDetergent} ml.");
            }

        }
    }
}
