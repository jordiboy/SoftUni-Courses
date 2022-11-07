using System;
using System.Collections.Generic;

namespace P03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] inputArgs = input.Split();
                string product = inputArgs[0];
                double price = double.Parse(inputArgs[1]);
                double qty = double.Parse(inputArgs[2]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(qty);
                }
                else
                {
                    if (products[product][0] != price)
                    {
                        products[product].RemoveAt(0);
                        products[product].Insert(0, price);
                        products[product][1] += qty;
                    }
                    
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}
