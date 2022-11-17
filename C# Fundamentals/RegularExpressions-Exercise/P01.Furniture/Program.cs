using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace P01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string validPattern = @">>(?<item>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<count>\d+)";

            List<string> items = new List<string>();

            double total = 0;

            string input;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                var validEntry = Regex.Matches(input, validPattern);

                foreach (Match item in validEntry)
                {
                    var name = item.Groups["item"].Value;
                    var price = double.Parse(item.Groups["price"].Value);
                    var count = int.Parse(item.Groups["count"].Value);

                    items.Add(name);
                    total += (double)count * price;
                }                                
            }            
            Console.WriteLine("Bought furniture:");

            if (items.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, items));
            }
            
            Console.WriteLine($"Total money spend: {total:f2}");
            
        }
    }
}
