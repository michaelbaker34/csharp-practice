﻿using System;
using static GenericsTest.BookList;

namespace GenericsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { Isbn = "1111", Title = "Title" };

            var numbers = new GenericList<int>();
            numbers.Add(10);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
    }
}
