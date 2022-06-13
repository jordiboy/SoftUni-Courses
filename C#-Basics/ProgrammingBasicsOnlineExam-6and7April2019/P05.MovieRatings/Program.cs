using System;

namespace P05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMovies = int.Parse(Console.ReadLine());

            string maxRMovie = string.Empty;
            string minRMovie = string.Empty;
            double maxRating = double.MinValue;
            double minRating = double.MaxValue;
            double totalRating = 0;
            int counter = 0;

            for (int i = 1; i <= countMovies; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                totalRating += movieRating;
                counter++;

                if (movieRating > maxRating)
                {
                    maxRating = movieRating;
                    maxRMovie = movieName;
                }
                else if (movieRating < minRating)
                {
                    minRating = movieRating;
                    minRMovie = movieName;
                }

            }

            double avgRating = totalRating / counter;

            Console.WriteLine($"{maxRMovie} is with highest rating: {maxRating:f1}");
            Console.WriteLine($"{minRMovie} is with lowest rating: {minRating:f1}");
            Console.WriteLine($"Average rating: {avgRating:f1}");
        }
    }
}
