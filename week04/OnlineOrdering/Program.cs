using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "USA");
        Customer customer1 = new Customer("Alice", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", 101, 999.99f, 1));
        order1.AddProduct(new Product("Mouse", 102, 25.50f, 2));

        // Customer 2 (International)
        Address address2 = new Address("456 Queen St", "Toronto", "Canada");
        Customer customer2 = new Customer("Bob", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", 201, 600.00f, 1));
        order2.AddProduct(new Product("Case", 202, 15.00f, 1));
        order2.AddProduct(new Product("Screen Protector", 203, 10.00f, 2));

        // Display Order 1
        Console.WriteLine("Order 1 Packing Label:");
        foreach (var label in order1.GetPackingLabel())
        {
            Console.WriteLine($"Product ID: {label._id}, Name: {label._id}");
        }

        Console.WriteLine("\nOrder 1 Shipping Label:");
        var shipping1 = order1.GetShippingLabel();
        Console.WriteLine($"To: {shipping1._name}\nAddress: {shipping1._address}");

        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");

        Console.WriteLine("\n------------------------\n");

        // Display Order 2
        Console.WriteLine("Order 2 Packing Label:");
        foreach (var label in order2.GetPackingLabel())
        {
            Console.WriteLine($"Product ID: {label._id}, Name: {label._name}");
        }

        Console.WriteLine("\nOrder 2 Shipping Label:");
        var shipping2 = order2.GetShippingLabel();
        Console.WriteLine($"To: {shipping2._name}\nAddress: {shipping2._address}");

        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}
