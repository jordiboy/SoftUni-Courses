using System;

namespace P06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            double power = 0;
            string powerWord = string.Empty;

            while (input != "End of words")
            {
                int wordLength = input.Length;
                double total;
                double sum = 0;

                for (int i = 0; i < wordLength; i++)
                {                    
                    sum += input[i];
                }
                
                switch (input[0])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'Y':
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':
                        total = sum * wordLength;
                            break;
                    default:
                        total = sum / wordLength;
                        break;
                }

                if (total > power)
                {
                    power = total;
                    powerWord = input;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {powerWord} - {power}");
        }
    }
}
