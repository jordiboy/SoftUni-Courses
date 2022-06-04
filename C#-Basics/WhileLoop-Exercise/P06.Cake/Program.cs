using System;

namespace P06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int pieces = a * b;

            while (pieces > 0)
            {
                string input = Console.ReadLine();

                if (input != "STOP")
                {
                    int curenPieces = int.Parse(input);
                    pieces -= curenPieces;
                }
                else
                {
                    break;
                }
            }

            if (pieces <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
        }
    }
}
