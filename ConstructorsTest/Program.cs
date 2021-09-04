using System;

namespace ConstructorsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Bob");
            var order = new Order();

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(order);
        }
    }
}
