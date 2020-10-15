using System;

namespace BookClassLibrary
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pages;
        private string _Isbn13;


        public string Title
        {
            get { return _title; }
            set { _title = value.Length < 2 ? throw new ArgumentOutOfRangeException() : value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Pages
        {
            get { return _pages; }
            set => _pages = value < 10 & value > 1000 ? throw new ArgumentOutOfRangeException() : value;
        }

        public string Isbn13
        {
            get { return _Isbn13; }
            set
            {
                _Isbn13 = value.Length == 13 ? value : throw new ArgumentOutOfRangeException();

            }
        }

        public Book()
        {

        }


        public Book(string title, string author, int pages, string isbn13)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Isbn13 = isbn13;

        }
    }
}
