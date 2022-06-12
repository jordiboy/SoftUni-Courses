using System;

namespace P06.WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int countRows = int.Parse(Console.ReadLine());
            int places = int.Parse(Console.ReadLine());

            int moreRows = 0;
            int counterPlaces = 0;
            int startPlace = 97;

            for (char sector = 'A'; sector <= lastSector; sector++)
            { 
                for (int row = 1; row <= countRows + moreRows; row++)
                {
                    if (row % 2 == 0)
                    {
                        for (int place = startPlace; place < startPlace + places + 2; place++)
                        {
                            Console.WriteLine($"{sector}{row}{(char)place}");
                            counterPlaces++;
                        }
                    }
                    else if (row % 2 != 0)
                    {
                        for (int place = startPlace; place < startPlace + places; place++)
                        {
                            Console.WriteLine($"{sector}{row}{(char)place}");
                            counterPlaces++;
                        }
                    }                    
                }

                moreRows++;                
            }

            Console.WriteLine(counterPlaces);
        }
    }
}
