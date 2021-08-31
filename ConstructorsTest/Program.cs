using System;

namespace ConstructorsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
