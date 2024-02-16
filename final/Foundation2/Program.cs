using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Product A", 1, 10.50m, 2);
        Product product2 = new Product("Product B", 2, 20.75m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost()}");

        // Create another order
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product3 = new Product("Product C", 3, 15.25m, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost()}");
    }
}
