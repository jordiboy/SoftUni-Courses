using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace P05.NetherRealms
{
    public class Demon
    {
        public Demon(string name, int totalHelth, double totalDamage)
        {
            Name = name;
            TotalHelth = totalHelth;
            TotalDamage = totalDamage;
        }

        public string Name { get; set; }
        public int TotalHelth { get; set; }
        public double TotalDamage { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {            
            string[] input = Regex.Split(Console.ReadLine(), @" *,{1} *");

            List<Demon> demons = new List<Demon>();

            foreach (var demon in input)
            {
                string name = demon;
                int totalHelth = TotalHelth(demon);
                double totalDamage = Damage(demon);

                Demon newDemon = new Demon(name, totalHelth, totalDamage);

                demons.Add(newDemon);
            }

            PrintOutput(demons);
        }
        public static void PrintOutput(List<Demon> demons)
        {
            foreach (var demon in demons.OrderBy(n => n.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.TotalHelth} health, {demon.TotalDamage:f2} damage");
            }
        }
        public static int TotalHelth(string demonName)
        {
            int helth = 0;
            string pattern = @"[^+\-*\/.\d]";

            var sumHelth = Regex.Matches(demonName, pattern).ToArray();            

            foreach (Match item in sumHelth)
            {                
                helth += char.Parse(item.Value);
            }

            return helth;
        }
        public static double Damage(string demonName)
        {
            string pattern = @"(?<digits>([-|+])*?\d+(\.\d+)?)";

            MatchCollection digits = Regex.Matches(demonName, pattern);

            double totalDamage = 0;

            foreach (Match digit in digits)
            {
                totalDamage += double.Parse(digit.Groups["digits"].Value);
            }
            
            foreach (var ch in demonName)
            {
                if (ch == '*')
                {
                    totalDamage *= 2;
                }
                else if (ch == '/' && totalDamage > 0)
                {                    
                    totalDamage /= 2;                                    
                }
            }
            return totalDamage;
        }
    }
}
