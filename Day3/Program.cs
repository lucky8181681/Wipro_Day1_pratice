using System;

namespace Day3
{
    class Program
    {
        static void Main()
        {
            // Method Overloading
            Console.WriteLine(MethodOverloading.Add(10, 20));
            Console.WriteLine(MethodOverloading.Add(10, 20, 30));

            // Method Overriding
            Animal obj = new Dog();
            obj.Sound();
        }
    }
}