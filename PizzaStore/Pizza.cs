using System;
namespace PizzaStore
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Pizza(int pizzaID, string name, double price)
        {
            PizzaID = pizzaID;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Pizza: {Name}";
        }
    }
}

