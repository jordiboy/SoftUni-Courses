using System;

namespace P02.RadianstoDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double grade = (radians * 180) / Math.PI;
            Console.WriteLine(grade);
        }
    }
}
