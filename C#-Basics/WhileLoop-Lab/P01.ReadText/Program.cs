using System;

namespace P01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";

            while ((text = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(text);
            }
        }
    }
}
