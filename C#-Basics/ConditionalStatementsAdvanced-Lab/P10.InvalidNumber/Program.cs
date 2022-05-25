using System;

namespace P10.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isValid = (num >= 100 && num <= 200 || num == 0);

            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
