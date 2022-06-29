using System;

namespace P05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 1; i <= num; i++)
            {
                string digits = Console.ReadLine();
                int length = digits.Length;
                int mainDigit = digits[0] - 48;
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }

                if (mainDigit == 0)
                {
                    message += ' ';
                }
                else
                {
                    int letterIndex = offset + length - 1;
                    message += (char)(97 + letterIndex);
                }
            }

            Console.WriteLine(message);
        }
    }
}
