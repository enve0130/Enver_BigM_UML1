using System;
namespace PizzaStore
{
    public class Order
    {
        public int OrderID { get; set; }
        public Pizza Pizza { get; set; }
        public Customer Customer { get; set; }
        private const double TaxRate = 0.25;
        private const double DeliveryCost = 40;

        public Order(int orderID, Pizza pizza, Customer customer)
        {
            OrderID = orderID;
            Pizza = pizza;
            Customer = customer;
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = Pizza.Price + DeliveryCost;
            totalPrice += totalPrice * TaxRate;
            return totalPrice;
        }

        public override string ToString()
        {
            return $"{Pizza.ToString()}, {Customer.ToString()}, Total Price: {CalculateTotalPrice()} DKK";
        }
    }
}

