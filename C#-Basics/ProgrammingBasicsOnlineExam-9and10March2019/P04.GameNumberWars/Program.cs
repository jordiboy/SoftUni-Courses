using System;

namespace P04.GameNumberWars
{
    class Program
    {
        static void Main(string[] args)
        {
            string player1 = Console.ReadLine();
            string player2 = Console.ReadLine();

            int points = 0;
            int player1Points = 0;
            int player2Points = 0;
            bool isNumberWars = false;
            string winner = string.Empty;

            string input = Console.ReadLine();

            while (input != "End of game")
            {
                int card1 = int.Parse(input);
                int card2 = int.Parse(Console.ReadLine());

                if (isNumberWars == true)
                {
                    if (card1 > card2)
                    {
                        points = player1Points;
                        winner = player1;
                    }
                    else
                    {
                        points = player2Points;
                        winner = player2;
                    }

                    break;
                }

                if (card1 > card2)
                {
                    player1Points += card1 - card2;
                }
                else if (card2 > card1)
                {
                    player2Points += card2 - card1;
                }
                else 
                {
                    isNumberWars = true;                    
                }

                input = Console.ReadLine();
            }

            if (isNumberWars == true)
            {
                Console.WriteLine("Number wars!");
                Console.WriteLine($"{winner} is winner with {points} points");
            }
            else
            {
                Console.WriteLine($"{player1} has {player1Points} points");
                Console.WriteLine($"{player2} has {player2Points} points");
            }
        }
    }
}
