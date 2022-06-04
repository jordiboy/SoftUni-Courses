using System;

namespace P01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();

            int count = 0;
            string search;

            while ((search = Console.ReadLine()) != "No More Books")
            {                
                if (search == book)
                {                    
                    Console.WriteLine($"You checked {count} books and found it.");
                    return;
                }

                count++;
            }
            
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count} books.");
        }
    }
}
