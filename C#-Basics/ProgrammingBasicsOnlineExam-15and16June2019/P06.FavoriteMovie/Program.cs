using System;

namespace P06.FavoriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int total = 0;
            int counter = 0;
            string movie = string.Empty;

            while (movieName != "STOP")
            {
                int length = movieName.Length;
                int sum = 0;
                counter++;

                for (int i = 0; i < length; i++)
                {
                    if (movieName[i] >= 'A' && movieName[i] <= 'Z')
                    {
                        sum += movieName[i] - length;
                    }
                    else if (movieName[i] >= 'a' && movieName[i] <= 'z')
                    {
                        sum += movieName[i] - (2 * length);
                    }
                    else
                    {
                        sum += movieName[i];
                    }

                    if (sum > total)
                    {
                        total = sum;
                        movie = movieName;
                    }
                }
                if (counter == 7)
                {
                    break;
                }

                movieName = Console.ReadLine();
            }

            if (counter == 7)
            {
                Console.WriteLine("The limit is reached.");                
            }

            Console.WriteLine($"The best movie for you is {movie} with {total} ASCII sum.");
        }
    }
}
