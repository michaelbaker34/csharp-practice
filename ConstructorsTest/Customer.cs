using System;

namespace ConstructorsTest
{
    public class Customer
    {
        public int Id;
        public string Name;


        // default constructor
        public Customer()
        {
        }

        public Customer(int id)
        {
            this.Id = id;
        }

        // constructor overload
        public Customer(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }

    }
}
