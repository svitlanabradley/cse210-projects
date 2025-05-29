using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order #1
        Address address1 = new Address("456 Oak Street", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 999.99m, 1));
        order1.AddProduct(new Product("Mouse", 102, 25.50m, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.OrderTotalCost()}");
        Console.WriteLine("-------------------------");

        // Order #2
        Address address2 = new Address("123 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 799.99m, 1));
        order2.AddProduct(new Product("Charger", 202, 19.99m, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.OrderTotalCost()}");        
    }
}