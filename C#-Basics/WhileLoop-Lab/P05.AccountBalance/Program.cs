using System;

namespace P05.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string payment = Console.ReadLine();

            double sum = 0;

            while (payment != "NoMoreMoney")
            {
                double money = double.Parse(payment);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {money:f2}");
                    sum += money;

                    payment = Console.ReadLine();
                }
                
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
