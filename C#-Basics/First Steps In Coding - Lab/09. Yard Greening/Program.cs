using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double total = area * 7.61;
            double discount = total * 0.18;
            total -= discount;
            Console.WriteLine($"The final price is: {total:f2} lv.");
            Console.WriteLine($"The discount is: {discount:f2} lv.");
        }
    }
}
