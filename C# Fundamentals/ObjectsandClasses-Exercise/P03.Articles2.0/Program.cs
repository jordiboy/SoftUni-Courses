using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Articles2._0
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>(); 

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article newArticle = new Article(title, content, author);
                articles.Add(newArticle);
            }

            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }                
        }
    }
}
