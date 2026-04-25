using System;
class Product
{
    private string name;
    private double price;
    private int quantity;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Price
    {
        get { return price; }
        set
        {
            price = value;
        }
    }
    public int Quantity
    {
        get { return quantity; }
        set
        {
            quantity = value;
        }
    }
}
class ProductCollection
{
    private Product[] products;
    public ProductCollection(int size)
    {
        products = new Product[size];
    }
    public Product this[int index]  // allows accessing obj like array--store,access,update
    {
        get
        {
            if (index < 0 || index >= products.Length)
                throw new IndexOutOfRangeException("Invalid index");
            return products[index];
        }
        set
        {
            if (index < 0 || index >= products.Length)
                throw new IndexOutOfRangeException("Invalid index");
            products[index] = value;
        }
    }
    public int Length => products.Length;
}
class Program
{
    static void Main()
    {
        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());
        ProductCollection inventory = new ProductCollection(n);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nEnter details for Product {i + 1}:");
            Product p = new Product();
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Price: ");
            p.Price = double.Parse(Console.ReadLine());
            Console.Write("Quantity: ");
            p.Quantity = int.Parse(Console.ReadLine());
            inventory[i] = p;
        }
        Console.WriteLine("\nAll Products:");
        for (int i = 0; i < inventory.Length; i++)
        {
            Console.WriteLine($"Product {i + 1}: {inventory[i].Name}, Rs. {inventory[i].Price}, Qty: {inventory[i].Quantity}");
        }
        Console.Write("\nEnter index to update (0-based): ");
        int idx = int.Parse(Console.ReadLine());

        Console.Write("Enter new price: ");
        double newPrice = double.Parse(Console.ReadLine());

        inventory[idx].Price = newPrice;

        Console.WriteLine("\nUpdated Product:");
        Console.WriteLine($"{inventory[idx].Name}, Rs. {inventory[idx].Price}, Qty: {inventory[idx].Quantity}");
    }
}