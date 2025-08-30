namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            //string command = Console.ReadLine();
            Console.WriteLine(GetGoldenBooks(db));


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

                bool isEnumValid = Enum
                    .TryParse("Gold", true, out EditionType editionType);                

                string[] goldBooks = context.Books
                    .Where(gb => gb.EditionType == editionType && gb.Copies < 5000)
                    .Select(gb => gb.Title)
                    .ToArray();
                    
                foreach (var goldBook in goldBooks)
                {
                    result
                        .AppendLine(goldBook);
                }

                return result.ToString().TrimEnd();
            }
        }
    }
}


