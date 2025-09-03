namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            //int input = int.Parse((Console.ReadLine()));
            Console.WriteLine(GetTotalProfitByCategory(db));


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


            // Problem 8 - Author Search

            static string GetAuthorNamesEndingIn(BookShopContext context, string input)
            {
                var result = new StringBuilder();

                var autors = context.Authors
                    .Where(a => a.FirstName.EndsWith(input))
                    .Select(a => new { a.FirstName, a.LastName })
                    .OrderBy(a => a.FirstName) 
                    .ToArray();

                foreach (var author in autors)
                {
                    result
                        .AppendLine ($"{author.FirstName} {author.LastName}");
                }

                return result.ToString().TrimEnd();
            }


            // Problem 9 - Book Search

            static string GetBookTitlesContaining(BookShopContext context, string input)
            {
                var result = new StringBuilder();

                var books = context.Books
                    .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                    .OrderBy(b => b.Title)
                    .ToArray();

                foreach (var book in books)
                {
                    result
                        .AppendLine (book.Title);
                }

                return result.ToString().TrimEnd();
            }


            // Problem 10 - Book Search by Author

            static string GetBooksByAuthor(BookShopContext context, string input)
            {
                var result = new StringBuilder();

                var books = context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                    .OrderBy(b => b.BookId)
                    .Select(b => new
                    {
                        BookTitle = b.Title,
                        AuthorFirstName = b.Author.FirstName,
                        AuthorLastName = b.Author.LastName,
                    })
                    .ToArray();

                foreach (var book in books)
                {
                    result 
                        .AppendLine ($"{book.BookTitle} ({book.AuthorFirstName} {book.AuthorLastName})");
                }

                return result.ToString().TrimEnd();

            }


            // Problem 11 - Count Books

            static int CountBooks(BookShopContext context, int lengthCheck)
            {
                var books = context.Books
                    .Where(b => b.Title.Length > lengthCheck)
                    .Select (b => b.Title)
                    .ToArray();

                int count = 0;

                foreach (var book in books)
                {
                    count++;
                }
                
                return count;
            }


            //Problem 12 - Total Book Copies

            static string CountCopiesByAuthor(BookShopContext context)
            {
                StringBuilder result = new StringBuilder();

                var authorCopies = context.Authors
                    .Include(a => a.Books)
                    .Select(a => new
                    {
                        a.FirstName,
                        a.LastName,
                        TotalCopies = a.Books
                        .Sum(b => b.Copies)
                    })
                    .ToArray()
                    .OrderByDescending(b => b.TotalCopies)
                    .ToArray();

                foreach (var author in authorCopies)
                {
                    result
                        .AppendLine($"{author.FirstName} {author.LastName} - {author.TotalCopies}");
                }

                return result.ToString().TrimEnd();
            }


            // Problem 13 - Profit by Category

            static string GetTotalProfitByCategory(BookShopContext context)
            {
                StringBuilder result = new StringBuilder();

                var bookCategories = context.Categories
                    .Include(c => c.CategoryBooks)
                    .ThenInclude(cb => cb.Category)
                    .Select(c => new    
                            { 
                                c.Name,
                                TotalProfit = c.CategoryBooks
                                .Sum(cb => cb.Book.Price * cb.Book.Copies)
                            })
                    .OrderByDescending(cb => cb.TotalProfit)
                    .ThenBy(cb => cb.Name)
                    .ToArray();

                foreach (var category in bookCategories)
                {
                    result
                        .AppendLine($"{category.Name} ${category.TotalProfit:f2}");
                }

                    return result.ToString().TrimEnd();
            }
        }
    }
}


