using System;

namespace P05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            

            for (int i = 1; i <= n; i++)
            {
                bool isSpecial = false;
                int sum = 0;
                int num = i;

                for (int j = 1; j <= i; j++)
                {                    
                    sum += num % 10;
                    num /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;                    
                } 
                
                Console.WriteLine($"{i} -> {isSpecial}");                             
                
            }
        }
    }
}
