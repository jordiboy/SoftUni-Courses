using System;

namespace P02.AddBags
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceLuggage = double.Parse(Console.ReadLine());
            int kgLuggage = int.Parse(Console.ReadLine());
            int countDays = int.Parse(Console.ReadLine());
            int countLuggages = int.Parse(Console.ReadLine());

            double price = 0;

            if (kgLuggage < 10)
            {
                price = priceLuggage * 0.2;
            }
            else if (kgLuggage <= 20)
            {
                price = priceLuggage * 0.5;
            }
            else
            {
                price = priceLuggage;
            }

            if (countDays > 30)
            {
                price += price * 0.1;
            }
            else if (countDays >= 7 && countDays <= 30)
            {
                price += price * 0.15;
            }
            else if (countDays < 7)
            {
                price += price * 0.4;
            }

            double total = countLuggages * price;

            Console.WriteLine($"The total price of bags is: {total:f2} lv. ");
        }
    }
}
