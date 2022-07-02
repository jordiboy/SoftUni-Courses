using System;
using System.Linq;

namespace P08.CondenseArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[numbers.Length];            

            while (numbers.Length > 1)
            {
                Array.Resize(ref condensed, condensed.Length - 1);

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers.Length > 1)
                    {
                        condensed[i] = numbers[i] + numbers[i + 1];
                    }                    
                }

                Array.Resize(ref numbers, numbers.Length - 1);
                numbers = condensed;
                
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
