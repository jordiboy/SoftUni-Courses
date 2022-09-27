using System;
using System.Linq;

namespace P07.MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int biggerSequence = 0;
            int sequence = 1;
            int counter = 1;

            for (int i = 0; i < array.Length - 1; i++)
            { 
                
                if (array[i] == array[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;                        
                }           

                if (counter > sequence)
                {
                    sequence = counter;
                    biggerSequence = array[i];
                }                
            }

            for (int i = 0; i < sequence; i++)
            {
                Console.Write($"{biggerSequence} ");
            }
        }
    }
}
