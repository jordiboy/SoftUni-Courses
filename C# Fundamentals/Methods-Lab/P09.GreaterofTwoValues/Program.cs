using System;

namespace P09.GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            if (type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                GetMax(a, b);
            }
            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                GetMax(a, b);
            }
            if (type == "string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                GetMax(a, b);
            }
        }
        public static void GetMax(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        public static void GetMax(char a, char b)
        {
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        public static void GetMax(string a, string b)
        {
            if (a[0] > b[0])
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
