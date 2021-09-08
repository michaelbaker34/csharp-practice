using System;
using static GenericsTest.BookList;

namespace GenericsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var book = new Book { Isbn = "1111", Title = "Title" };

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());

            //System.Nullable
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value ? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

            var empty = new Nullable<int>();
            Console.WriteLine("Has Value ? " + empty.HasValue);
            Console.WriteLine("Value: " + empty.GetValueOrDefault());
        }
    }
}
