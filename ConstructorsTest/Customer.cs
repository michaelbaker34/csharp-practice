using System.Collections.Generic;

namespace ConstructorsTest
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public List<string> Colors;


        // default constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        // overload
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

    }
}
