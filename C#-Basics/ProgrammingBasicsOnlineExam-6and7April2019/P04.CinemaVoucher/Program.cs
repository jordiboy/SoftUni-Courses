using System;

namespace P04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int voucher = int.Parse(Console.ReadLine());

            int countTickets = 0;
            int countOthers = 0;            

            string input = Console.ReadLine();

            while (input != "End")
            {
                int length = input.Length;
                int currsum = 0;

                if (length > 8)
                {
                    if (input[0] + input[1] <= voucher)
                    {
                        currsum = input[0] + input[1];
                        countTickets++;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (length <= 8)
                {
                    if (input[0] <= voucher)
                    {
                        currsum = input[0];
                        countOthers++;
                    }
                    else
                    {
                        break;
                    }
                    
                }
                else
                {
                    break;
                }

                voucher -= currsum;

                input = Console.ReadLine();
            }

            Console.WriteLine($"{countTickets}");
            Console.WriteLine($"{countOthers}");
        }
    }
}
