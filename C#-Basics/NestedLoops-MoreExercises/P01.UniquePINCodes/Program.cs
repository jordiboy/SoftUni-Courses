using System;

namespace P01.UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code is the same in "08. Secret Door's Lock"

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            for (int firstOne = 1; firstOne <= first; firstOne++)
            {                
                for (int secondOne = 1; secondOne <= second; secondOne++)
                {
                    for (int thirdOne = 1; thirdOne <= third; thirdOne++)
                    {
                        int firstNum = 0, secondNum = 0, thirdNum = 0;

                        if (firstOne % 2 == 0)
                        {
                            firstNum = firstOne;
                        }                        
                        if (secondOne == 2 || secondOne == 3 || secondOne == 5 || secondOne == 7)
                        {
                            secondNum = secondOne;
                        }                        
                        if (thirdOne % 2 == 0)
                        {
                            thirdNum = thirdOne;
                        }                        

                        if (firstNum != 0 && secondNum != 0 && thirdNum != 0)
                        {
                            Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
                        }
                        
                    }
                    
                }
                
            }
        }
    }
}
