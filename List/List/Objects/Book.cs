using System;
using System.Collections.Generic;

namespace List.Objects
{
    public class Book
    {
        public String Title;
        public String Author;
        public String Type;
        public  Boolean Read;

        public Book()
        {
        }

        public Book(String Title)
        {
            this.Title = Title;
        }

        public  Boolean MarkAsRead(Book book)
        {
            book.Read = true;
            return Read;
        }

        
    }
}
