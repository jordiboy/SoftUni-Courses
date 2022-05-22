using System;

namespace P02.GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            if (num1 > num2)
            {
                max = num1;
            }
            else
            {
                max = num2;
            }
            Console.WriteLine(max);
        }
    }
}
