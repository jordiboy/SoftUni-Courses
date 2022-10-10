using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> player2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int count = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                if (player1[i] > player2[i])
                {
                    player1.Add(player1[i]);
                    player1.Add(player2[i]);
                    player1.RemoveAt(i);
                    player2.RemoveAt(i);
                }
                else if (player2[i] > player1[i])
                {
                    player2.Add(player2[i]);
                    player2.Add(player1[i]);
                    player1.RemoveAt(i);
                    player2.RemoveAt(i);
                }
                else
                {
                    player1.RemoveAt(i);
                    player2.RemoveAt(i);
                }

                if (player1.Count < player2.Count)
                {
                    count = player1.Count;
                }
                else
                {
                    count = player2.Count;
                }

                i = -1;
            }
            if (player1.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
            }
        }
    }
}
