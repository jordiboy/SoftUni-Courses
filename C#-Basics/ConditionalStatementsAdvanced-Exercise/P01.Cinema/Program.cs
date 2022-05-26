using System;

namespace P01.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int places = rows * cols;
            double total = 0;

            switch (type)
            {
                case "Premiere":
                    total = places * 12.00;
                    break;
                case "Normal":
                    total = places * 7.50;
                    break;
                case "Discount":
                    total = places * 5.00;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"{total:f2} leva");
        }
    }
}
