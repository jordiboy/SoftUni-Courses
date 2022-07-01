using System;

namespace P10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            double percent100 = (double)n * 0.5;
            int hits = 0;

            while (n >= m)
            {
                n -= m;
                hits++;

                if (percent100 == n && y != 0)
                {
                    n /= y;                                                            
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(hits);
        }
    }
}
