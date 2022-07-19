using System;

namespace P08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number, power));
        }
        private static double RaiseToPower(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
