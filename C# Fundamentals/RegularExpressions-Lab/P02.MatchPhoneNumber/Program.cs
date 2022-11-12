using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string phones = Console.ReadLine();

            MatchCollection mathedPhones = Regex.Matches(phones, regex);
            List<string> numbers = new List<string>();

            foreach (Match phone in mathedPhones)
            {
                numbers.Add(phone.Value);
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
