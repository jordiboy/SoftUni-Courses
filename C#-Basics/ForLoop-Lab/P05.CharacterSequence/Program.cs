using System;

namespace P05.CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int length = name.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
