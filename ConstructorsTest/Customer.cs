using System.Collections.Generic;

namespace ConstructorsTest
{
    public class Customer
    {
        public int Id;
        public string Name;
        // empty params initialize without constructor
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        // overload
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
        }

    }
}
