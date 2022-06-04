using System;

namespace P07.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int min = int.MaxValue;

            while (num != "Stop")
            {
                int number = int.Parse(num);

                if (number < min)
                {
                    min = number;
                }

                num = Console.ReadLine();
            }

            Console.WriteLine(min);
        }
    }
}
