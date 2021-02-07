using System;
using System.Collections.Generic;
using List.Objects;
namespace List
{
    class Program
    {

    //pomocne funkcie na vypis listov integerov a stringov
        public static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item},");

            }
            Console.Write("\n");
        }

        public static void PrintList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item},");

            }
            Console.Write("\n");
        }

        public static void PrintList(List<Book> lib)
        {
            foreach (Book book in lib)
            {
             
                Console.Write($"{book.Title},");

            }
            Console.Write("\n");
        }


        static void Main(string[] args)
        {
            //inicializace instancii listu

            var numbers = new List<int>();
            var strings = new List<String>();
            var books = new List<Book>();


            //deklarace hodnot listu

            var ints = new List<int>() { 2, 5, 6, 7, 99 };
            var str = new List<String>() { "Cucoriedka", "Cernica", "Bambuca" };
            Book b1 = new Book("Pribeh studia Pixar");
            Book b2 = new Book("Telesna vychova");
            Book b3 = new Book("Ako sa ludia hraju");
            var numb = new List<int>();

            var lib = new List<Book>() { b1, b2 };

            PrintList(ints);
            PrintList(str);
            PrintList(lib);

            //methody nad triedou list

            lib.Add(b3);
            ints.Remove(99);
            str.Remove("Cernica");
            numb.AddRange(new List<int>() { 2, 6 });

            PrintList(ints);
            PrintList(str);
            PrintList(lib);
            PrintList(numb);


        }

    }
}
