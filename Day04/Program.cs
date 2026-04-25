using System;
using System.Collections.Generic;

namespace Day4   
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            Dictionary<int, Customer> customers = new Dictionary<int, Customer>();
            HashSet<string> categories = new HashSet<string>();
            Queue<Order> orderQueue = new Queue<Order>();

            customers[1] = new Customer(1, "Sneha");
            customers[2] = new Customer(2, "Alok");

            Order o1 = new Order(101, 1, "Electronics");
            Order o2 = new Order(102, 2, "Clothing");

            orders.Add(o1);
            orders.Add(o2);

            categories.Add(o1.Category);
            categories.Add(o2.Category);
            categories.Add("Electronics"); // duplicate ignored

            o1.AddStatus("Placed");
            o1.AddStatus("Shipped");

            o2.AddStatus("Placed");

            orderQueue.Enqueue(o1);
            orderQueue.Enqueue(o2);

            Console.WriteLine("Updating Order 102");
            o2.Category = "Fashion";

            Console.WriteLine("Removing Order 101");
            orders.Remove(o1);

            Console.WriteLine("\nProcessing Orders:");
            while (orderQueue.Count > 0)
            {
                var order = orderQueue.Dequeue();
                var customer = customers[order.CustomerId];
                Console.WriteLine($"Processing Order: {order.OrderId}, Customer: {customer.Name}");
            }

            Console.WriteLine("\nOrder Status History:");
            foreach (var order in orders)
            {
                var customer = customers[order.CustomerId];
                Console.WriteLine($"Order {order.OrderId} for {customer.Name}:");
                order.ShowStatus();
            }

            Console.WriteLine("\nUnique Categories:");
            foreach (var cat in categories)
            {
                Console.WriteLine(cat);
            }
        }
    }
}