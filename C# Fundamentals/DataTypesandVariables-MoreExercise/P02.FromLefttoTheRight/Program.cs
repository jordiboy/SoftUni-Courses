using System;
using System.Linq;

namespace P02.FromLefttoTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string nums = Console.ReadLine();
                long leftNum;
                long rightNum;
                int sumLeft = 0;
                int sumRight = 0;
                bool isLeftFound = false;
                string left = string.Empty;
                string right = string.Empty;

                for (int j = 0; j < nums.Length; j++)
                {                    
                    string digit = nums[j].ToString();

                    if (isLeftFound == false && nums[j] != ' ')
                    {
                        left += nums[j];

                        if (nums[j] != '-')
                        {
                            sumLeft += int.Parse(digit);
                        }                        
                    }
                    else if (isLeftFound == false && nums[j] == ' ')
                    {
                        isLeftFound = true;
                    }
                    else if (isLeftFound == true && nums[j] != ' ')
                    {
                        right += nums[j];

                        if (nums[j] != '-')
                        {
                            sumRight += int.Parse(digit);
                        }                        
                    }                    
                }

                leftNum = long.Parse(left);
                rightNum = long.Parse(right);

                if (leftNum > rightNum)
                {
                    Console.WriteLine($"{sumLeft}");
                }
                else
                {
                    Console.WriteLine($"{sumRight}");
                }
            }
        }
    }
}
