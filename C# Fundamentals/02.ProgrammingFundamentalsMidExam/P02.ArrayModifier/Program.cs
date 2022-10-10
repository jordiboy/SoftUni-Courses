using System;
using System.Linq;

namespace P02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string manipulation = tokens[0];                

                if (manipulation == "swap")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    Swap(array, index1, index2);
                }
                else if (manipulation == "multiply")
                {
                    int index1 = int.Parse(tokens[1]);
                    int index2 = int.Parse(tokens[2]);
                    Multiply(array, index1, index2);
                }
                else if (manipulation == "decrease")
                {
                    Decrease(array);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }
        public static void Swap(int[] array, int index1, int index2)
        {            
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        public static void Multiply(int[] array, int index1, int index2)
        {
            array[index1] *= array[index2];
        }
        public static void Decrease(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= 1;
            }
        }
    }
}
