using System;

namespace P14.PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int character = l + 96;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int k = 97; k <= character; k++)
                    {
                        for (int m = 97; m <= character; m++)
                        {
                            for (int o = i; o <= n; o++)
                            {
                                if (o > i && o > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)m}{o} ");
                                }                                
                            }
                        }
                    }
                }
            }
        }
    }
}
