using System;

namespace P01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;

            for (int row = 1; row <= num; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (current > num)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write($"{current} ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
