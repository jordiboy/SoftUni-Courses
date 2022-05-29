using System;

namespace P07.FuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine().ToLower();
            double liters = double.Parse(Console.ReadLine());

            if (fuel == "diesel" || fuel == "gasoline" || fuel == "gas")
            {

                if (liters < 25)
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
                else
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
