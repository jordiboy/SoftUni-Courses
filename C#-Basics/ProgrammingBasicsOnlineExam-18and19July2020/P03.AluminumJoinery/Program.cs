using System;

namespace P03.AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJoinery = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string recievingType = Console.ReadLine();

            if (countJoinery <= 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }

            double price = 0;

            if (type == "90X130")
            {
                price = 110;

                if (countJoinery > 30 && countJoinery <= 60)
                {
                    price -= price * 0.05;
                }
                else if (countJoinery > 60)
                {
                    price -= price * 0.08;
                }                
            }
            else if (type == "100X150")
            {
                price = 140;

                if (countJoinery > 40 && countJoinery <= 80)
                {
                    price -= price * 0.06;
                }
                else if (countJoinery > 80)
                {
                    price -= price * 0.1;
                }
            }
            else if (type == "130X180")
            {
                price = 190;

                if (countJoinery > 20 && countJoinery <= 50)
                {
                    price -= price * 0.07;
                }
                else if (countJoinery > 50)
                {
                    price -= price * 0.12;
                }
            }
            else if (type == "200X300")
            {
                price = 250;

                if (countJoinery > 25 && countJoinery <= 50)
                {
                    price -= price * 0.09;
                }
                else if (countJoinery > 50)
                {
                    price -= price * 0.14;
                }
            }

            double total = price * countJoinery;

            switch (recievingType)
            {
                case "With delivery":total += 60; break;
            }

            if (countJoinery >= 100)
            {
                total -= total * 0.04;
            }

            Console.WriteLine($"{total:f2} BGN");
        }
    }
}
