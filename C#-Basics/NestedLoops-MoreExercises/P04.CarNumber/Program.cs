using System;

namespace P04.CarNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = begining; i <= end; i++)
            {
                for (int j = begining; j <= end; j++)
                {
                    for (int k = begining; k <= end; k++)
                    {
                        for (int l = begining; l <= end; l++)
                        {
                            if (i > l && (j + k) % 2 == 0)
                            {
                                if (i % 2 == 0 && l % 2 != 0 || i % 2 != 0 && l % 2 == 0)
                                {
                                    Console.Write($"{i}{j}{k}{l} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
