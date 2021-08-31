using System;

namespace ConstructorsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Bob");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
