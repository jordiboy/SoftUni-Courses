using System;
using System.Text;

namespace P07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); //abv>1>1>2>2asdasd

            StringBuilder sb = new StringBuilder();

            int power = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    string currpower = input[i + 1].ToString();
                    power += int.Parse(currpower);
                }

                if (power > 0 && input[i] != '>')
                {
                    power--;                                        
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
