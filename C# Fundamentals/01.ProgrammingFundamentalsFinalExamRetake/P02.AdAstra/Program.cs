using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.AdAstra
{
    class Program
    {
        public class Item
        {
            public Item(string name, string date, int calories)
            {
                Name = name;
                Date = date;
                Calories = calories;
            }

            public string Name { get; set; }
            public string Date { get; set; }
            public int Calories { get; set; }
        }
        static void Main(string[] args)
        {            
            string input = Console.ReadLine();

            string pattern = @"(#|\|)(?<item>[A-Za-z ]+)+\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<cals>\d+)\1";
            List<Item> products = new List<Item>();

            MatchCollection matches = Regex.Matches(input, pattern);

            int totalCals = 0;            

            foreach (Match match in matches)
            {
                string item = match.Groups["item"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["cals"].Value);

                Item newItem = new Item(item, date, calories);
                products.Add(newItem);
                totalCals += calories;
            }

            int days = totalCals / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (var product in products)
            {
                Console.WriteLine($"Item: {product.Name}, Best before: {product.Date}, Nutrition: {product.Calories}");
            }
            
        }
    }
}
