using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("123 main street", "Holywood", "CA", "USA");
        Address address2 = new Address ("456 Abel Street", "Ikoyi", "LAG", "Nigeria");
        Customer customer1 = new Customer ("Joseph Smith", address1);
        Customer customer2 = new Customer ("Brigham Young", address2);

        Product product1 = new Product ("Laptop", 1001, 9.00m, 2);
        Product product2 = new Product ("IPhone", 1002, 14.50m, 3);
        Product product3 = new Product ("Television", 1003, 12.00m, 1);

        Order order1 = new Order (customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("order 1: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total cost: {order1.TotalCost():F2}");

        Console.WriteLine();

        Console.WriteLine("order 2: ");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total cost: {order2.TotalCost():F2}");
    }
}