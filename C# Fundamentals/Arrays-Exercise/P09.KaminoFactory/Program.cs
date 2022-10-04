using System;
using System.Linq;

namespace P09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int samples = 0;
            int bestSample = 0;
            int bestCount = 0;
            int bestSum = int.MinValue;
            int smalerIndex = -1;
            int[] bestDNASample = new int[length];            

            string command = Console.ReadLine();

            while (command != "Clone them!")
            {
                int[] dna = command    
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                samples++;

                int currentCount = 0;                
                int counter = 0;
                int sum = 0;
                int currentIndex = -1;                
                bool isBestDNA = false;

                for (int i = 0; i < dna.Length; i++)
                {
                    if (dna[i] ==  0)
                    {
                        counter = 0;
                        continue;
                    }
                    counter++;

                    if (counter > currentCount)
                    {
                        currentCount = counter;                        
                        currentIndex = i - currentCount + 1;
                    }
                }
                                
                sum = dna.Sum();

                if (currentCount > bestCount)
                {
                    isBestDNA = true;
                }
                else if (currentCount == bestCount)
                {
                    if (currentIndex < smalerIndex)
                    {
                        isBestDNA = true;
                    }
                    else if (currentIndex == smalerIndex)
                    {
                        if (sum > bestSum)
                        {
                            isBestDNA = true;
                        }
                    }
                }

                if (isBestDNA)
                {
                    bestCount = currentCount;
                    smalerIndex = currentIndex;
                    bestSum = sum;
                    bestSample = samples;
                    bestDNASample = dna;                    
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.Write(string.Join(" ", bestDNASample));
        }
    }
}
