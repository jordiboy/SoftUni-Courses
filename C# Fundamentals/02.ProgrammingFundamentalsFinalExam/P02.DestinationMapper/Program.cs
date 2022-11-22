using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)(?<place>[A-Z][A-Za-z]{2,})\1";

            List<string> list = new List<string>();

            MatchCollection places = Regex.Matches(input, pattern);

            int travelPoints = 0;

            foreach (Match match in places)
            {
                string place = match.Groups["place"].Value;
                travelPoints += place.Length;
                list.Add(place);
            }
            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
