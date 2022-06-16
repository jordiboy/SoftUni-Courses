using System;

namespace P06.NameGame
{
    class Program
    {
        static void Main(string[] args)
        { 
            int maxScore = 0;
            string winnerName = string.Empty;            

            string name = Console.ReadLine();

            while (name != "Stop")
            {
                int n = name.Length;
                
                int points = 0;

                for (int i = 0; i < n; i++)
                {

                    int number = int.Parse(Console.ReadLine());

                    if (name[i] == number)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }

                if (points >= maxScore)
                {
                    maxScore = points;
                    winnerName = name;
                }

                name = Console.ReadLine();
            }                        
            
            Console.WriteLine($"The winner is {winnerName} with {maxScore} points!");  
        }
    }
}
