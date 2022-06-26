using System;

namespace P05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            int bestGouls = 0;
            string bestPlayer = string.Empty;
            bool isHattrick = false;

            string player = Console.ReadLine();

            while (player != "END")
            {
                int countGouls = int.Parse(Console.ReadLine());

                if (bestGouls < countGouls)
                {
                    bestGouls = countGouls;
                    bestPlayer = player;
                }
                
                if (countGouls >= 3)
                {
                    isHattrick = true;
                }

                if (countGouls >= 10)
                {
                    break;
                }

                player = Console.ReadLine();
            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (isHattrick == true)
            {
                Console.WriteLine($"He has scored {bestGouls} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestGouls} goals.");
            }
        }
    }
}
