using System;

namespace P11.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {           
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            double total = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            total = count * 2.5;
                            break;
                        case "apple":
                            total = count * 1.2;
                            break;
                        case "orange":
                            total = count * 0.85;
                            break;
                        case "grapefruit":
                            total = count * 1.45;
                            break;
                        case "kiwi":
                            total = count * 2.7;
                            break;
                        case "pineapple":
                            total = count * 5.5;
                            break;
                        case "grapes":
                            total = count * 3.85;
                            break;                        
                    }                    
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            total = count * 2.7;
                            break;
                        case "apple":
                            total = count * 1.25;
                            break;
                        case "orange":
                            total = count * 0.9;
                            break;
                        case "grapefruit":
                            total = count * 1.6;
                            break;
                        case "kiwi":
                            total = count * 3;
                            break;
                        case "pineapple":
                            total = count * 5.6;
                            break;
                        case "grapes":
                            total = count * 4.2;
                            break;                        
                    }
                    break;                
            }

            if (total > 0)
            {
                Console.WriteLine($"{total:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
