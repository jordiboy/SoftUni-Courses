namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            string input = (Console.ReadLine());
            Console.WriteLine(GetBooksReleasedBefore(db, input));


            //Problem 2 - Age Restriction

            static string GetBooksByAgeRestriction(BookShopContext context, string command)
            {
                StringBuilder result = new StringBuilder();

                bool isEnumValid = Enum
                    .TryParse(command, true, out AgeRestriction ageRestriction);

                if (!isEnumValid)
                {
                    return string.Empty;
                }

                string[] bookTitles = context
                    .Books
                    .Where(b => b.AgeRestriction == ageRestriction)
                    .OrderBy(b => b.Title)
                    .Select(b => b.Title)
                    .ToArray();

                foreach (var bookTitle in bookTitles)
                {
                    result
                        .AppendLine($"{bookTitle}");
                }

                return result.ToString().TrimEnd();
            }

            // Problem 3 - Golden Books

            static string GetGoldenBooks(BookShopContext context)
            {
                StringBuilder result = new StringBuilder();
                
                string[] goldBooks = context.Books
                    .Where(gb => gb.EditionType == EditionType.Gold && gb.Copies < 5000)
                    .Select(gb => gb.Title)
                    .ToArray();
                    
                foreach (var goldBook in goldBooks)
                {
                    result
                        .AppendLine(goldBook);
                }

                return result.ToString().TrimEnd();
            }


            // Problem 4 - Books by Price

            static string GetBooksByPrice(BookShopContext context)
            {
                StringBuilder result = new StringBuilder();

                var booksByPrices = context.Books
                    .Where(b => b.Price > 40)
                    .OrderByDescending(b => b.Price)
                    .Select(b => new
                    {
                        b.Title,
                        b.Price
                    })                    
                    .ToArray();

                foreach (var book in booksByPrices)
                {
                    result
                        .AppendLine($"{book.Title} - ${book.Price:f2}");
                }

                return result.ToString().TrimEnd();
            }


            // Problem 5 - Not Released In

            static string GetBooksNotReleasedIn(BookShopContext context, int year)
            {
                StringBuilder result = new StringBuilder();

                var books = context.Books
                    .Where(b => b.ReleaseDate.Value.Year != year)
                    .OrderBy(b => b.BookId)
                    .Select(b => b.Title)                    
                    .ToArray();

                foreach (var book in books)
                {
                    result
                        .AppendLine($"{book}");
                }

                return result.ToString().TrimEnd();
            }


            // Problem 6 - Book Titles by Category

            static string GetBooksByCategory(BookShopContext context, string input)
            {
                StringBuilder result = new StringBuilder();

                string[] searchBooksCategories = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => c.ToLower())
                    .ToArray();

                var books = context.Books
                    .Include(b => b.BookCategories)
                    .ThenInclude(bc => bc.Category)
                    .Where(b => b.BookCategories
                        .Any(bc => searchBooksCategories.Contains(bc.Category.Name)))
                    .OrderBy(b => b.Title)
                    .ToArray();

                foreach (var book in books)
                {
                    result
                        .AppendLine(book.Title);
                }

                return result.ToString().TrimEnd();
            }


            // Problem 7 - Released Before Date

            static string GetBooksReleasedBefore(BookShopContext context, string date)
            {
                StringBuilder result = new StringBuilder();

                DateTime dateBefore = DateTime.Parse(date);

                var books = context.Books
                    .Where(b => b.ReleaseDate < dateBefore)
                    .OrderByDescending(b => b.ReleaseDate)
                    .Select(b => new
                    {
                        b.Title,
                        b.EditionType,
                        b.Price
                    })
                    .ToArray();

                foreach (var book in books)
                {
                    result 
                        .AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
                }

                return result.ToString().TrimEnd();
            }
        }
    }
}


