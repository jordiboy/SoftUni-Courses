using System;

namespace P05.ChallengetheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int man = int.Parse(Console.ReadLine());
            int woman = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = 1; i <= man; i++)
            {
                for (int j = 1; j <= woman; j++)
                {                    
                    counter++;

                    if (counter <= tables)
                    {
                        Console.Write($"({i} <-> {j}) ");
                    }
                }
            }
        }
    }
}
