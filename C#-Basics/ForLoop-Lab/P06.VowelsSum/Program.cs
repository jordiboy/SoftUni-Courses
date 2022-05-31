using System;

namespace P06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int length = word.Length;
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'u':
                        sum += 5;
                        break;                    
                }
            }

            Console.WriteLine(sum);
        }
    }
}
