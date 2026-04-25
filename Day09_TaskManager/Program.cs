using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true)
        {
            Console.WriteLine("\n--- Task Manager ---");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter task: ");
                string task = Console.ReadLine();
                tasks.Add(task);
                Console.WriteLine("Task added!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("\n--- Your Tasks ---");
                if (tasks.Count == 0)
                {
                    Console.WriteLine("No tasks available.");
                }
                else
                {
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                }
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}