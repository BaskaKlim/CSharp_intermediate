using System;

namespace Triedy
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            book1.Title = "Príbeh štúdia Pixar";
            book1.Author = "Lawrence Levy";
            book1.ISBN = "9788081820700";

            Console.WriteLine(book1.Title);
        }
    }
}
