using System;

namespace P03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());

            double sum = deposit * (interest / 100);
            interest = sum / 12;
            double totalInterest = period * interest;
            sum = deposit + totalInterest;
            Console.WriteLine(sum);
        }
    }
}
