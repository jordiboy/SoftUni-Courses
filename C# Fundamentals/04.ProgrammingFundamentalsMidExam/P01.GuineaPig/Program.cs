using System;

namespace P01.GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal food = decimal.Parse(Console.ReadLine());
            decimal hay = decimal.Parse(Console.ReadLine());
            decimal cover = decimal.Parse(Console.ReadLine());
            decimal weight = decimal.Parse(Console.ReadLine());
                        
            int month = 30;            

            for (int i = 1; i <= month; i++)
            {                                   
                food -= 0.3m;

                if (i % 2 == 0)
                {                        
                    hay -= food * 0.05m;
                }
                if (i % 3 == 0)
                {
                    cover -= weight / 3;                        
                }
                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    break;
                }                
            }

            if (food <= 0 || hay <= 0 || cover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");                
            }
        }
    }
}
