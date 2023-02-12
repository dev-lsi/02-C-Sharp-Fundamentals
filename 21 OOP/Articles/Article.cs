using System;
using System.Collections.Generic;
using System.Text;

namespace Articles
{
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
