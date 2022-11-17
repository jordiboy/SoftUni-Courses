using System;
using System.Text.RegularExpressions;

namespace P06.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)[A-Za-z0-9]+([-|.|_]?\w+)*?@\w+([.|-]?\w+)*\.\w+";
            string text = Console.ReadLine();

            MatchCollection emails = Regex.Matches(text, pattern);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
