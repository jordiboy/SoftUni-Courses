using System;

namespace P07.FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadium = int.Parse(Console.ReadLine());
            int countFans = int.Parse(Console.ReadLine());

            double[] counter = new double[4];       // i0 = A; i1 = B; i2 = V; i3 = G

            for (int i = 1; i <= countFans; i++)
            {
                char curentSector = char.Parse(Console.ReadLine());

                switch (curentSector)
                {
                    case 'A':
                        counter[0]++;
                        break;
                    case 'B':
                        counter[1]++;
                        break;
                    case 'V':
                        counter[2]++;
                        break;
                    case 'G':
                        counter[3]++;
                        break;                    
                }
            }

            Console.WriteLine($"{(counter[0] / countFans) * 100:f2}%");
            Console.WriteLine($"{(counter[1] / countFans) * 100:f2}%");
            Console.WriteLine($"{(counter[2] / countFans) * 100:f2}%");
            Console.WriteLine($"{(counter[3] / countFans) * 100:f2}%");
            Console.WriteLine($"{((double)countFans / stadium) * 100:f2}%");
        }
    }
}
