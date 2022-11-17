using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace P04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string pattern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*?:(?<population>\d+)[^@\-!:>]*?!(?<attacktype>[A|D])![^@\-!:>]*?->(?<countsolders>\d+)";

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {                
                string input = Console.ReadLine();
                string decriptedMessage = DecriptedMessage(input);

                Match message = Regex.Match(decriptedMessage, pattern);

                if (message.Success)
                {
                    string planet = message.Groups["planet"].Value;
                    string attackType = message.Groups["attacktype"].Value;

                    if (attackType == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attackType == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }                
            }

            PrintOutput(attackedPlanets, destroyedPlanets);
        }
        public static void PrintOutput(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
        public static string DecriptedMessage(string message)
        {
            StringBuilder decriptedMessage = new StringBuilder();

            int decriptionKey = DecriptionKey(message);

            foreach (var item in message)
            {
                char currChar = (char)(item - decriptionKey);
                decriptedMessage.Append(currChar);
            }
            return decriptedMessage.ToString();
        }
        public static int DecriptionKey(string message)
        {
            string pattern = @"[star]";
            MatchCollection mathes = Regex.Matches(message, pattern, RegexOptions.IgnoreCase);

            return mathes.Count;
        }
    }
}
