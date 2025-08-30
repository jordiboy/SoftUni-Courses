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

            string command = Console.ReadLine();
            Console.WriteLine(GetBooksByAgeRestriction(db, command));


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
        }
    }
}


