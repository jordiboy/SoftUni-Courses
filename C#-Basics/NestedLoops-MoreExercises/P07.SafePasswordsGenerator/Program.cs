using System;

namespace P07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPass = int.Parse(Console.ReadLine());

            int counter = 0;
            int c = 35;
            int d = 64;

            
            for (int e = 1; e <= a; e++)
            {
                for (int f = 1; f <= b; f++)
                {

                    Console.Write($"{(char)c}{(char)d}{e}{f}{(char)d}{(char)c}|");

                    counter++;
                    c++;
                    d++;

                    if (counter >= maxPass)
                    {
                        return;
                    }
                    if (c > 55)
                    {
                        c = 35;
                    }
                    if (d > 96)
                    {
                        d = 64;
                    }                    
                }
            } 
        }
    }
}
