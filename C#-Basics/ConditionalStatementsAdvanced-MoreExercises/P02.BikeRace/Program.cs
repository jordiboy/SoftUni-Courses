using System;

namespace P02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJuniors = int.Parse(Console.ReadLine());
            int countSeniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();

            double taxJuniors = 0;
            double taxSeniors = 0;
            double discount = 0;

            if (route == "trail")
            {
                taxJuniors = countJuniors * 5.5;
                taxSeniors = countSeniors * 7;
            }
            else if (route == "cross-country")
            {
                taxJuniors = countJuniors * 8;
                taxSeniors = countSeniors * 9.5;

                if (countJuniors + countSeniors >= 50)
                {
                    discount = (taxJuniors + taxSeniors) * 0.25;
                }
            }
            else if (route == "downhill")
            {
                taxJuniors = countJuniors * 12.25;
                taxSeniors = countSeniors * 13.75;
            }
            else if (route == "road")
            {
                taxJuniors = countJuniors * 20;
                taxSeniors = countSeniors * 21.5;
            }

            double total = taxJuniors + taxSeniors - discount;
            double expenses = total * 0.05;

            total -= expenses;

            Console.WriteLine($"{total:f2}");
        }
    }
}
