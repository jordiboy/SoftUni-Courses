using System;

namespace P09.FruitorVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();

            switch (product)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes":
                    product = "fruit";
                    break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    product = "vegetable";
                    break;
                default:
                    product = "unknown";
                    break;
            }
            Console.WriteLine(product);
        }
    }
}
