using System;

namespace P11.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double sum = (days * capsulesCount) * price;
                total += sum;

                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
