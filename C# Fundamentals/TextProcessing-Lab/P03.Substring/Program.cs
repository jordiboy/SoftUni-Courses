using System;
using System.Linq;

namespace P03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRemouve = Console.ReadLine();
            string word = Console.ReadLine();


            while (word.Contains(toRemouve))
            {
                int index = word.IndexOf(toRemouve);
                int length = toRemouve.Length;
                word = word.Remove(index, length);
            }
            Console.WriteLine(word);
        }
    }
}
