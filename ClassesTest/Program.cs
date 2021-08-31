using System;

namespace ClassesTest
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}, I am {1}", to, Name);
        }


        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Bob");

            person.Introduce("Bill");
        }

    }
}
