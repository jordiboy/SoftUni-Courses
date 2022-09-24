using System;

namespace P06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBalanced = true;                        
            int countOpen = 0;
            int countClosed = 0;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {                                     
                    countOpen++;                                                        
                }
                else if (input == ")")
                {                    
                    countClosed++;   
                    
                    if (countClosed - countOpen != 0)
                    {
                        isBalanced = false;
                    }
                }
            }

            if (isBalanced && countClosed == countOpen)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
