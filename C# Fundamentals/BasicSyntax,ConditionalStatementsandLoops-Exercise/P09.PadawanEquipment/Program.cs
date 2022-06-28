using System;

namespace P09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());

            double countLightsabers = Math.Ceiling(countStudents + (countStudents * 0.1));

            double lightsabers = countLightsabers * priceLightsabers;
            double robes = countStudents * priceRobes;
            double belts = (countStudents - (countStudents / 6)) * priceBelts;

            double total = lightsabers + robes + belts;

            if (total <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {total - budget:f2}lv more.");
            }
        }
    }
}
