using System;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> list = new List<Article>();
            
            for (int i = 0; i < n; i++)
            {
               string[] input = Console.ReadLine().Split(", ");
               Article article = new Article(input[0], input[1], input[2]);
                list.Add(article);

            }

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            //•	Edit(new content) – change the old content with the new one
            public void Edit(string newContent)
            {
                Content = newContent;
            }

            //•	ChangeAuthor(new author) – change the author
            public void ChangeAuthor(string newAuthor)
            {
                Author = newAuthor;
            }
            //•	Rename(new title) – change the title of the article
            public void Rename(string newName)
            {
                Title = newName;
            }
            //•	Override the ToString method – print the article in the following format: 
            //"{title} - {content}: {author}"
            public override string ToString()
            {

                return $"{Title} - {Content}: {Author}";
            }

        }
    }
}
