using System;
using System.Text;
using System.Linq;

namespace P05.Digits_LettersandOther
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            string input = Console.ReadLine();

            foreach (var character in input)
            {
                if (char.IsDigit(character))
                {
                    digits.Append(character);
                }
                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }
                else if (!char.IsLetterOrDigit(character))
                {
                    others.Append(character);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
