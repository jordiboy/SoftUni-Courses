using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Articles
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(List<string> content, string newContent)
        {
            content.RemoveAt(1);
            content.Insert(1, newContent);
        }
        public void ChangeAuthor(List<string> autor, string newAutor)
        {
            autor.RemoveAt(2);
            autor.Insert(2, newAutor);
        }
        public void Rename(List<string> title, string newTitle)
        {
            title.RemoveAt(0);
            title.Insert(0, newTitle);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> article = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string title = article[0];
            string content = article[1];
            string author = article[2];

            Article newArticle = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());            

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(": ");
                string action = input[0];
                string change = input[1];

                if (action == "Edit")
                {
                    newArticle.Edit(article, change);
                }
                else if (action == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(article, change);
                }
                else if (action == "Rename")
                {
                    newArticle.Rename(article, change);
                }
            }

            Console.WriteLine($"{article[0]} - {article[1]}: {article[2]}");
        }
    }
}
