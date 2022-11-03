using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.StoreBoxes
{
    class Program
    {
        class Box
        {
            public string SerialNumber { get; set; }
            public string Item { get; set; }
            public int Quantity { get; set; }
            public decimal PriceBox { get; set; } 
        }
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Box box = new Box();

                box.SerialNumber = data[0];
                box.Item = data[1];
                box.Quantity = int.Parse(data[2]);
                box.PriceBox = decimal.Parse(data[3]);

                boxes.Add(box);

                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(p => p.PriceBox * p.Quantity).ToList();

            foreach (var box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - ${box.PriceBox:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceBox * box.Quantity:f2}");
            }
        }
    }
}
