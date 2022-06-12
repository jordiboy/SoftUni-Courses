using System;

namespace P12.Thesongofthewheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());

            int counter = 0;
            string password = "";
            bool isPassword = false;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (a < b && c > d)
                            {
                                if ((a * b) + (c * d) == controlNum)
                                {
                                    counter++;

                                    if (counter == 4)
                                    {
                                        isPassword = true;
                                        password = $"{a}{b}{c}{d}";
                                    }

                                    Console.Write($"{a}{b}{c}{d} ");
                                }                                
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            if (isPassword == true)
            {
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
