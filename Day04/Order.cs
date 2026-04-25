using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    internal class Order
    {
        public int OrderId;
        public int CustomerId;
        public string Category;

        private Stack<string> statusHistory = new Stack<string>();

        public Order(int orderId, int customerId, string category)
        {
            OrderId = orderId;
            CustomerId = customerId;
            Category = category;
        }

        public void AddStatus(string status)
        {
            statusHistory.Push(status);
        }

        public void ShowStatus()
        {
            
            foreach (var status in statusHistory)
            {
                Console.WriteLine(status);
            }
        }
    }
}
