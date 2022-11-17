using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace P03.SoftUniBarIncome
{
    class Program
    {
        public class Purchase
        {
            public Purchase(string name, string product, decimal price)
            {
                Name = name;
                Product = product;
                Price = price;
            }

            public string Name { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
        }
        static void Main(string[] args)
        {
            string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)\$";

            List<Purchase> purchases = new List<Purchase>();

            decimal total = 0m;
            string input;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match validPurchase = Regex.Match(input, pattern);                

                if (validPurchase.Success)
                {
                    string name = validPurchase.Groups["name"].Value;
                    string product = validPurchase.Groups["product"].Value;
                    int count = int.Parse(validPurchase.Groups["count"].Value);
                    decimal price = decimal.Parse(validPurchase.Groups["price"].Value);

                    price *= count;

                    Purchase newPurchase = new Purchase(name, product, price);                    

                    purchases.Add(newPurchase);
                }
            }

            foreach (var item in purchases)
            {
                Console.WriteLine($"{item.Name}: {item.Product} - {item.Price:f2}");
                total += item.Price;
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}
