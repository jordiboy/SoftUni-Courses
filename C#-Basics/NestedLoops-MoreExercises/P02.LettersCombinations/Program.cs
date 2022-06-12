using System;

namespace P02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());
            char character3 = char.Parse(Console.ReadLine());

            int combinations = 0;

            for (char i = character1; i <= character2; i++)
            {
                for (char j = character1; j <= character2; j++)
                {
                    for (char k = character1; k <= character2; k++)
                    {
                        if (i != character3 && j != character3 && k != character3)
                        {
                            Console.Write($"{i}{j}{k} ");
                            combinations++;
                        }
                    }
                }
            }
            Console.Write(combinations);
        }
    }
}
