# 🛒 Day 4 - E-Commerce Order Management System (C#)

## 📌 Overview
This project demonstrates a simple **Order Management System** using C# collections.  
It simulates how an e-commerce backend manages orders, customers, categories, and processing workflows.

---

## 🎯 Objectives
- Add, update, and remove orders  
- Process orders in sequence (FIFO)  
- Track order status changes (LIFO)  
- Maintain unique product categories  

---

## 🧩 Collections Used

| Collection | Purpose |
|-----------|--------|
| List<Order> | Store all orders |
| Dictionary<int, Customer> | Map customer ID to customer details |
| HashSet<string> | Store unique product categories |
| Queue<Order> | Process orders in FIFO order |
| Stack<string> | Track order status history (LIFO) |

---

## ⚙️ Features Implemented

### ✅ Add Orders
Orders are created and stored using `List<Order>`.

### ✅ Update Orders
Order details (like category) can be modified.

### ✅ Remove Orders
Orders can be removed from the system.

### ✅ Process Orders (FIFO)
Orders are processed using a Queue:
- First added → First processed

### ✅ Track Status (LIFO)
Each order maintains a Stack of status updates:
- Latest status appears first

### ✅ Unique Categories
HashSet ensures:
- No duplicate categories


---

## ⚠️ Important Notes

- Even after removing an order from the list, it may still be processed if it was already added to the Queue.
- This reflects real-world systems where queued tasks continue execution unless explicitly cancelled.

---

## 💡 Key Concepts

- C# Collections usage  
- FIFO (Queue) vs LIFO (Stack)  
- Dictionary for fast lookup  
- HashSet for uniqueness  
- Clean code structure  

---

## 🚀 Future Enhancements

- Menu-driven user input  
- Search and filter orders  
- Order cancellation handling  
- Convert into Web API (ASP.NET Core)  
- Database integration  

---

## 👩‍💻 Author
Sneha 

