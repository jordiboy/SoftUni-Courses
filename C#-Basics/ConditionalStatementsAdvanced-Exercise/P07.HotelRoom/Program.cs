using System;

namespace P07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int countNights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartment = 0;

            if (month == "May" || month == "October")
            {
                studio = countNights * 50.0;
                apartment = countNights * 65.0;
                if (countNights > 7 && countNights < 14)
                {
                    double discount = studio * 0.05;
                    studio -= discount;
                }
                else if (countNights > 14)
                {
                    double discount = studio * 0.3;
                    studio -= discount;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = countNights * 75.2;
                apartment = countNights * 68.7;
                if (countNights > 14)
                {
                    double discount = studio * 0.2;
                    studio -= discount;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = countNights * 76.0;
                apartment = countNights * 77.0;
            }
            if (countNights > 14)
            {
                double discount = apartment * 0.1;
                apartment -= discount;
            }
            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
