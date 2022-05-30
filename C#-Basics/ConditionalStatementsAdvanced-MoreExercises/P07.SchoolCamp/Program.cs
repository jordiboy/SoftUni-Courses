using System;

namespace P07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int countStudents = int.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());

            string sport = "";
            double pricePerNight = 0;

            if (season == "Winter")
            {
                if (group == "boys")
                {
                    sport = "Judo";
                    pricePerNight = 9.6;
                }
                else if (group == "girls")
                {
                    sport = "Gymnastics";
                    pricePerNight = 9.6;
                }
                else if (group == "mixed")
                {
                    sport = "Ski";
                    pricePerNight = 10;
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys")
                {
                    sport = "Tennis";
                    pricePerNight = 7.2;
                }
                else if (group == "girls")
                {
                    sport = "Athletics";
                    pricePerNight = 7.2;
                }
                else if (group == "mixed")
                {
                    sport = "Cycling";
                    pricePerNight = 9.5;
                }
            }
            else if (season == "Summer")
            {
                if (group == "boys")
                {
                    sport = "Football";
                    pricePerNight = 15;
                }
                else if (group == "girls")
                {
                    sport = "Volleyball";
                    pricePerNight = 15;
                }
                else if (group == "mixed")
                {
                    sport = "Swimming";
                    pricePerNight = 20;
                }
            }

            double total = countNights * pricePerNight * countStudents;
            double discount = 0;

            if (countStudents >= 50)
            {
                discount = total * 0.5;
            }
            else if (countStudents >= 20)
            {
                discount = total * 0.15;
            }
            else if (countStudents >= 10)
            {
                discount = total * 0.05;
            }

            total -= discount;

            Console.WriteLine($"{sport} {total:f2} lv.");
        }
    }
}
