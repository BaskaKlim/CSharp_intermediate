using System;
using System.Collections.Generic;

namespace List.Objects
{
    public class Library
    {
        public Library()
        {
            List<Book> library = new List<Book>();  

        }
        public void PrintList(List<Book> library)
        {
            foreach (var book in library)
            {
                Console.Write($"{book},");

            }
            Console.Write("\n");
        }
    }
}
