using System;

namespace P01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    Manipulation(num1);
                    break;
                case "real":
                    double num2 = double.Parse(Console.ReadLine());
                    Manipulation(num2);
                    break;
                case "string":
                    string word = Console.ReadLine();
                    Manipulation(word);
                    break;
            }
        }
        private static void Manipulation(int num1)
        {
            Console.WriteLine(num1 * 2);
        }
        private static void Manipulation(double num2)
        {
            Console.WriteLine($"{num2 * 1.5:f2}");
        }
        private static void Manipulation(string word)
        {
            Console.WriteLine($"${word}$");
        }
    }
}
