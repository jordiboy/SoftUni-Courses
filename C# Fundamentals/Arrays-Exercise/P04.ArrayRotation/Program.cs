using System;
using System.Linq;

namespace P04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int[] rotatedArray = new int[array.Length];

                rotatedArray[rotatedArray.Length - 1] = array[0];

                for (int j = 0; j < rotatedArray.Length - 1; j++)
                {
                    rotatedArray[j] = array[j + 1];
                }
                
                array = rotatedArray;
            }

            Console.Write(string.Join(" ", array));
        }
    }
}
