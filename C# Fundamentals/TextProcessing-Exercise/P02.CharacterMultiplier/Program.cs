using System;

namespace P02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string str1 = input[0];
            string str2 = input[1];
            int total = 0;
            int length = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < length; i++)
            {
                total += str1[i] * str2[i];
            }

            int diff = Math.Abs(str1.Length - str2.Length);
            int newLength = Math.Max(str1.Length, str2.Length);

            for (int i = newLength - diff; i < newLength; i++)
            {
                if (str1.Length > str2.Length)
                {
                    total += str1[i];
                }
                else
                {
                    total += str2[i];
                }                
            }

            Console.WriteLine(total);
        }
    }
}
