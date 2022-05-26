using System;

namespace P03.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;

            switch (flowers)
            {
                case "Roses":
                    {
                        sum = count * 5.0;
                        if (count > 80)
                        {
                            double discount = sum * 0.1;
                            sum -= discount;
                        }
                        break;
                    }
                case "Dahlias":
                    {
                        sum = count * 3.8;
                        if (count > 90)
                        {
                            double discount = sum * 0.15;
                            sum -= discount;
                        }
                        break;
                    }
                case "Tulips":
                    {
                        sum = count * 2.8;
                        if (count > 80)
                        {
                            double discount = sum * 0.15;
                            sum -= discount;
                        }
                        break;
                    }
                case "Narcissus":
                    {
                        sum = count * 3.0;
                        if (count < 120)
                        {
                            double discount = sum * 0.15;
                            sum += discount;
                        }
                        break;
                    }
                case "Gladiolus":
                    {
                        sum = count * 2.5;
                        if (count < 80)
                        {
                            double discount = sum * 0.2;
                            sum += discount;
                        }
                        break;
                    }
            }

            if (budget >= sum)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {budget - sum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {sum - budget:f2} leva more.");
            }
        }
    }
}
