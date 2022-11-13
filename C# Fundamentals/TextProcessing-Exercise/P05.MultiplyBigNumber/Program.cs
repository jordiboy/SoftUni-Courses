using System;
using System.Text;
using System.Linq;

namespace P05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            int mindNum = 0;

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                
                int currnum = bigNumber[i] - '0';
                int currAction = number * currnum;

                if (number == 0)
                {
                    Console.WriteLine(0);
                    return;
                }

                if (mindNum > 0)
                {
                    currAction += mindNum;
                    mindNum = 0;
                } 
                
                string result = currAction.ToString();

                if (i == 0)
                {
                    char[] newResult= result.Reverse().ToArray();                    
                    sb.Append(new string(newResult));
                }
                else
                {
                    sb.Append(result.Last());
                    result = result.Substring(0, result.Length - 1);
                }               

                if (result != string.Empty && i > 0)
                {
                    mindNum += int.Parse(result);
                }                                
            }

            string resultToReverse = sb.ToString();

            for (int i = resultToReverse.Length - 1; i >= 0; i--)
            {
                Console.Write(resultToReverse[i]);
            }
        }
    }
}
