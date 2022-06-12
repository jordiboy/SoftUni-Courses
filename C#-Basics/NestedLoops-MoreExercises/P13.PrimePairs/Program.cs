using System;

namespace P13.PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int couple1 = int.Parse(Console.ReadLine());
            int couple2 = int.Parse(Console.ReadLine());
            int diff1 = int.Parse(Console.ReadLine());
            int diff2 = int.Parse(Console.ReadLine());

            for (int i = couple1; i <= couple1 + diff1; i++)
            {
                for (int j = couple2; j <= couple2 + diff2; j++)
                {
                    if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0 
                        && j % 2 != 0 && j % 3 != 0 && j % 5 != 0 && j % 7 != 0)
                    {
                        Console.WriteLine($"{i}{j}");
                        
                    }
                }                
            }
        }
    }
}
