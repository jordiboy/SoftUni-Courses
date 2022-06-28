using System;

namespace P03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (day == "Friday")
            {
                switch (type)
                {
                    case "Students": price = 8.45; break;
                    case "Business": price = 10.9; break;
                    case "Regular": price = 15; break;
                }
            }
            else if (day == "Saturday")
            {
                switch (type)
                {
                    case "Students": price = 9.8; break;
                    case "Business": price = 15.6; break;
                    case "Regular": price = 20; break;
                }
            }
            else if (day == "Sunday")
            {
                switch (type)
                {
                    case "Students": price = 10.46; break;
                    case "Business": price = 16; break;
                    case "Regular": price = 22.5; break;
                }
            }

            if (type == "Business" && countPeople >= 100)
            {
                countPeople -= 10;
            }

            double total = countPeople * price;

            if (type == "Students" && countPeople >= 30)
            {
                total -= total * 0.15;
            }

            if (type == "Regular" && countPeople >= 10 && countPeople <= 20)
            {
                total -= total * 0.05;
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
