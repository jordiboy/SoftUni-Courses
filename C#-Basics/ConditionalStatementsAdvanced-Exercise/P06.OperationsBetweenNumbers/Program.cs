using System;

namespace P06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            string even;
            double total;

            if (operation == '+')
            {
                total = num1 + num2;
                if (total % 2 == 0)
                {
                    even = "even";
                }
                else
                {
                    even = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {total} - {even}");
            }
            else if (operation == '-')
            {
                total = num1 - num2;
                if (total % 2 == 0)
                {
                    even = "even";
                }
                else
                {
                    even = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {total} - {even}");
            }
            else if (operation == '*')
            {
                total = num1 * num2;
                if (total % 2 == 0)
                {
                    even = "even";
                }
                else
                {
                    even = "odd";
                }
                Console.WriteLine($"{num1} {operation} {num2} = {total} - {even}");
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    total = (double)num1 / num2;
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                    return;
                }
                Console.WriteLine($"{num1} {operation} {num2} = {total:f2}");
            }
            else if (operation == '%')
            {
                if (num2 != 0)
                {
                    total = num1 % num2;
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                    return;
                }
                Console.WriteLine($"{num1} {operation} {num2} = {total}");
            }
            
        }
    }
}
