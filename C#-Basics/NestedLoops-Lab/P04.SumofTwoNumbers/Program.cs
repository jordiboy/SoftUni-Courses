using System;

namespace P04.SumofTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int countCombination = 0;
            bool isCombinationFound = false;

            for (int i = num1; i <= num2; i++)
            {                
                for (int j = num1; j <= num2; j++)
                {
                    countCombination++;

                    if (i + j == magicNum)
                    {                        
                        Console.WriteLine($"Combination N:{countCombination} ({i} + {j} = {magicNum})");
                        isCombinationFound = true;
                        break;
                    }                    
                }
                if(isCombinationFound == true)
                {
                    break;
                }
            }
            if (isCombinationFound == false)
            {
                Console.WriteLine($"{countCombination} combinations - neither equals {magicNum}");
            }            
        }
    }
}
