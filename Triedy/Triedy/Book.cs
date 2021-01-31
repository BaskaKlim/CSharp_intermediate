using System;
namespace Triedy
{
    public class Book
    {
        private int ID;
        public string Title;
        public string Author;
        public string ISBN;

        public Book()
        {
          
        }

        public Book(int ID, string ISBN, string Title, string Author)
        {
            this.ID = ID;
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
        }
    }
}
