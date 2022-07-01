using System;
using System.Numerics;

namespace P11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger bestTotal = 0;            
            string result = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());                

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);                                               

                if (bestTotal < snowballValue)
                {
                    bestTotal = snowballValue;
                    result = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                }
            }

            Console.WriteLine(result);
        }
    }
}
