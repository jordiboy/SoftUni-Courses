using System;

namespace P04.EasterEggsBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsFirstPlayer = int.Parse(Console.ReadLine());
            int eggsSecondPlayer = int.Parse(Console.ReadLine());

            string winner = Console.ReadLine();

            while (winner != "End")
            {
                switch (winner)
                {
                    case "one": eggsSecondPlayer--; break;
                    case "two": eggsFirstPlayer--; break;
                }

                if (eggsFirstPlayer == 0 || eggsSecondPlayer == 0)
                {
                    break;
                }

                winner = Console.ReadLine();
            }

            if (eggsFirstPlayer == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecondPlayer} eggs left.");
            }
            else if (eggsSecondPlayer == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirstPlayer} eggs left.");
            }
            else
            {
                Console.WriteLine($"Player one has {eggsFirstPlayer} eggs left.");
                Console.WriteLine($"Player two has {eggsSecondPlayer} eggs left.");
            }
        }
    }
}
