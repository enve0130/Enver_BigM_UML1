using System;
namespace PizzaStore
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        public Customer(int customerID, string name)
        {
            CustomerID = customerID;
            Name = name;
        }

        public override string ToString()
        {
            return $"Customer: {Name}";
        }
    }
}

