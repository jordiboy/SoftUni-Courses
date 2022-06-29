using System;

namespace P02.EnglishNameoftheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string number = num.ToString();            
            char lastDigit = number[number.Length - 1];
            string word = string.Empty;

            switch (lastDigit)
            {
                case '0': word = "zero"; break;
                case '1': word = "one"; break;
                case '2': word = "two"; break;
                case '3': word = "three"; break;
                case '4': word = "four"; break;
                case '5': word = "five"; break;
                case '6': word = "six"; break;
                case '7': word = "seven"; break;
                case '8': word = "eight"; break;
                case '9': word = "nine"; break;
            }

            Console.WriteLine($"{word}");
        }
    }
}
