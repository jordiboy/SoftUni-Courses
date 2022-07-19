using System;

namespace P03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine().ToLower();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add": Add(num1, num2); break;
                case "multiply": Multiply(num1, num2); break;
                case "subtract": Subtract(num1, num2); break;
                case "divide": Divide(num1, num2); break;
            }
        }
        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public static void Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
