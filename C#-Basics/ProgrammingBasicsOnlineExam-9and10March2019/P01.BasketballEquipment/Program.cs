using System;

namespace P01.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int basketballTax = int.Parse(Console.ReadLine());

            double sneekers = basketballTax - (basketballTax * 0.4);
            double outfit = sneekers - (sneekers * 0.2);
            double ball = outfit / 4;
            double accessories = ball / 5;

            double total = basketballTax + sneekers + outfit + ball + accessories;

            Console.WriteLine($"{total:f2}");
        }
    }
}
