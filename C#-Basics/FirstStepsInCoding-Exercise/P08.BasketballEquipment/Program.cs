using System;

namespace P08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());

            double sneekers = tax - (tax * 0.4);
            double outfit = sneekers - (sneekers * 0.2);
            double ball = outfit - (outfit * 0.75);
            double accessories = ball - (ball * 0.8);
            double sum = tax + sneekers + outfit + ball + accessories;
            Console.WriteLine(sum);
        }
    }
}
