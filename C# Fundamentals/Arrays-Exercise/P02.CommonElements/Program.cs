using System;
using System.Linq;

namespace P02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split()
                .ToArray();
            string[] array2 = Console.ReadLine()
                .Split()
                .ToArray();

            string[] common = new string[array2.Length];

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        common[i] = array2[i];
                    }
                }
            }

            for (int i = 0; i < common.Length; i++)
            {
                if (common[i] != null)
                {
                    Console.Write($"{common[i]} ");
                }
                
            }
        }
    }
}
