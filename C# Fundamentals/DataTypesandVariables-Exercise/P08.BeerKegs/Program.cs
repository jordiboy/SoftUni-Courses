using System;

namespace P08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bigger = 0;
            string biggerName = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (bigger < volume)
                {
                    bigger = volume;
                    biggerName = name;
                }
            }

            Console.WriteLine(biggerName);
        }
    }
}
