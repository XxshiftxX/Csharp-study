using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            Book gulliver = new Book();

            gulliver.Author = "Jonathan Swift";
            gulliver.ISBN13 = 9788983920075m;
            gulliver.Title = "걸리버 여행기";
            gulliver.Contents = "...";
            gulliver.PageCount = 384;
        }
    }


    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string contents, string author)
        {
            Title = title;
            Contents = contents;
            Author = author;
        }

        public void Open()
        {
            Console.WriteLine("Book is opened!");
        }

        public void Close()
        {
            Console.WriteLine("It's right. Boock is Closed");
        }
    }
}
