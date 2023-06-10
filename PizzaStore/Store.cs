using System;
namespace PizzaStore
{
    public class Store
    {
        public void Start()
        {
            Pizza pizza1 = new Pizza(1, "Margherita", 69);
            Pizza pizza2 = new Pizza(2, "Vesuvio", 75);
            Pizza pizza3 = new Pizza(3, "Capricciosa", 80);

            Customer customer1 = new Customer(1, "Martin Olsen");
            Customer customer2 = new Customer(2, "Lasse Jensen");
            Customer customer3 = new Customer(3, "Palle Poulsen");

            Order order1 = new Order(1, pizza1, customer1);
            Order order2 = new Order(2, pizza2, customer2);
            Order order3 = new Order(3, pizza3, customer3);

            Console.WriteLine(order1.ToString());
            Console.WriteLine(order2.ToString());
            Console.WriteLine(order3.ToString());
        }
    }
}

