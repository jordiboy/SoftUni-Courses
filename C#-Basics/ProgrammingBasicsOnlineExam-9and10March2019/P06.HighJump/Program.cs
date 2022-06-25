using System;

namespace P06.HighJump
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHight = int.Parse(Console.ReadLine());

            int currentHight = neededHight - 30;
            int jumpCounter = 0;
            int currHightCounter = 0;

            while (neededHight >= currentHight)
            {
                int hightJumped = int.Parse(Console.ReadLine());

                jumpCounter++;
                                
                if (currentHight < hightJumped)
                {
                    if (currentHight >= neededHight)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over {currentHight}cm after {jumpCounter} jumps.");
                        return;
                    }
                    currentHight += 5;
                    currHightCounter = 0;
                }
                else
                {
                    currHightCounter++;

                    if (currHightCounter == 3)
                    {
                        Console.WriteLine($"Tihomir failed at {currentHight}cm after {jumpCounter} jumps.");
                        return;
                    }
                }

            }            
              
        }
    }
}
