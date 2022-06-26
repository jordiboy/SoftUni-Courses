using System;
using System.Linq;

namespace P06.BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            var number1 = num1.ToString()
                .Select(x => int.Parse(x.ToString()))
                .ToArray();

            var number2 = num2.ToString()
                .Select(x => int.Parse(x.ToString()))
                .ToArray();

            for (int i = number1[0]; i <= number2[0]; i++)
            {
                for (int j = number1[1]; j <= number2[1]; j++)
                {
                    for (int k = number1[2]; k <= number2[2]; k++)
                    {
                        for (int l = number1[3]; l <= number2[3]; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }  
        }
    }
}
