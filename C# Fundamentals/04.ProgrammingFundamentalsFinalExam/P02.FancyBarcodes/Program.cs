using System;
using System.Text.RegularExpressions;

namespace P02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+(?<product>[A-Z][a-zA-Z0-9]{4,}[A-Z])@#+";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match barcode = Regex.Match(input, pattern);

                if (barcode.Success)
                {
                    string product = barcode.Groups["product"].Value;

                    string productGroup = string.Empty;

                    foreach (var ch in product)
                    {
                        if (Char.IsDigit(ch))
                        {
                            productGroup += ch;
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {productGroup}");
                    }                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }            
        }
    }
}
