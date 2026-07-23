using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address = new Address(
            "123 Corner Street",
            "Los Angeles",
            "Carlifornia",
            "USA");

        Customer customer = new Customer("John Doe", address);

        List<Product> products = new List<Product>
        {
            new Product("Jean", "P001", 2, 250m),
            new Product("T-shirt", "P002", 2, 150m)
        };

        Order order = new Order(customer, products);
        
        Console.WriteLine("Packing Label");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost()}");
    }
}