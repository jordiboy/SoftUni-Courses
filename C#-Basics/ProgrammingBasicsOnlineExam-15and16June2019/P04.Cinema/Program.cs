using System;

namespace P04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            bool isFull = false;
            int total = 0;

            string input = Console.ReadLine();

            while (input != "Movie time!")
            {

                int countPeople = int.Parse(input);
                int sum = 0;
                                

                if (capacity < countPeople)
                {
                    isFull = true;
                    break;
                }
                
                sum = countPeople * 5;

                if (countPeople % 3 == 0)
                {
                    sum -= 5;
                }

                capacity -= countPeople;

                total += sum;

                input = Console.ReadLine();
            }

            if (isFull == true )
            {
                Console.WriteLine("The cinema is full.");
            }
            else
            {
                Console.WriteLine($"There are {capacity} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {total} lv.");
        }
    }
}
