using System;

namespace P04.EvenPowersof2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= num; i += 2)
            {                                  
                    Console.WriteLine(Math.Pow(2, i));                                 
            }
        }
    }
}
