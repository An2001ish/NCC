using System;
using lab1;

namespace lab1
{
    class Book
    {
        public string Name;
        public int Pages;
        public string Author;

        public Book(string Name, int Pages, string Author)
        {
            this.Name = Name;
            this.Pages = Pages;
            this.Author = Author;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Name: {Name}, Pages: {Pages}, Author: {Author}");
        }

    }


}
