using System;
using static GenericsTest.BookList;

namespace GenericsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { BookIsbn = "1111", BookTitle = "Title" };

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.add("1234", new Book());
        }
    }
}
